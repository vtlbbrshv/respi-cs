using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using respi.Forms;

namespace respi.PortManager
{
    internal class DataManager
    {
        private const int DataSize = 64;
        private readonly byte[] _bufer = new byte[DataSize];
        private const string FilePath = @"./dataLog.txt";
        private readonly Chart _chart = new Chart();
        private readonly char[] _charsToTrim = { '\n' };
        private readonly char _splitSymbol;

        public DataManager(char splitSymbol)
        {
            _splitSymbol = splitSymbol;
            _chart.Show();
        }

        public void AddByte(SerialPort sender)
        {
            sender.Read(_bufer, 0, DataSize);
            ShowNewDataOnChart();
            WriteNewDataToFile();

        }

        private void WriteNewDataToFile()
        {
            var text = ConvertBytesToString(_bufer);

            using (var sw = new StreamWriter(FilePath, true)) 
            {
                sw.Write(text.Trim());
            }
        }

        private void ShowNewDataOnChart()
        {
            var data = SplitDataBySplitSymbol(ConvertBytesToString(_bufer));
            foreach (var el in data)
            {
                _chart.RenderNewData(el);
            }
        }

        private string ConvertBytesToString(byte[] data)
        {
            return Encoding.Default.GetString(data).Trim(_charsToTrim);
        }

        private double[] SplitDataBySplitSymbol(string str)
        {
            var splittedStr = str.Split(_splitSymbol);
            var arr = new double[splittedStr.Length];
            for(int i = 0; i < splittedStr.Length; i++)
            {
                arr[i] = Convert.ToDouble(splittedStr[i]);
            }

            return arr;
        }
    }
}
