using System.IO.Ports;

namespace respi.PortManager
{
    internal class PortManager
    {
        private const int DataSize = 64;
        private byte[] _bufer = new byte[DataSize];
        private readonly SerialPort _port;
        private readonly DataManager _receivedData;

        public PortManager(string portName, int portSpeed, char splitSymbol)
        {
            _port = new SerialPort(portName, portSpeed, Parity.None, 8, StopBits.One);
            _port.Open();
            _port.DataReceived += SerialPort_DataReceived;
            _receivedData = new DataManager(splitSymbol);
        }

        public void Close()
        {
            _port.Close();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var portSender = (SerialPort)sender;
            _receivedData.AddByte(portSender);
        }
    }
}
