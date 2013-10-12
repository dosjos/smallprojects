using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeAndDisplay(decimal x, decimal y)
        {
            MessageBox.Show(String.Format("{0}+{1}={2}", x, y, x + y));
        }

        private void DisplayResultButton_Click(object sender, EventArgs e)
        {
            ComputeAndDisplay(LeftOperand.Value, RightOperand.Value);
        }
    }
}
