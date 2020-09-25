using System.Windows.Forms;

namespace respi.Forms
{
    public partial class Chart : Form
    {
        private int _count = 1;        
        
        public Chart()
        {
            InitializeComponent();
        }

        public void RenderNewData(double y)
        {
            DataChart.Series["Respi"].Points.AddXY(_count, y);
            _count++;
        }
    }
}