using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Ports;

namespace respi
{
    public partial class Form1 : Form
    {
        private PortManager.PortManager _port;
        private readonly object[] _dataSpeed = { "9600", "19200", "38400", "57600", "74880", "115200" };
        private readonly object[] _splitSymbols = {",", "/", " ", "\n", "-", "\t"};

        public Form1()
        {
            InitializeComponent();
            var ports = SerialPort.GetPortNames();
            portSelector.Items.Clear();
            portSelector.Items.AddRange(ports);
            splitSymbolSelect.Items.AddRange(_splitSymbols);
            using (var sw = new StreamWriter(@"./test.txt", true)) 
            {
                sw.Write("hello");
            }
            speedSelect.Items.AddRange(_dataSpeed);
        }

        private void onButt_Click(object sender, EventArgs e)
        {
            _port = new PortManager.PortManager(portSelector.SelectedItem.ToString(), 
                Convert.ToInt32(speedSelect.SelectedItem.ToString()), 
                Convert.ToChar(splitSymbolSelect.SelectedItem.ToString()));
        }

        private void offButt_Click(object sender, EventArgs e)
        {
            _port.Close();
        }
    }
}
