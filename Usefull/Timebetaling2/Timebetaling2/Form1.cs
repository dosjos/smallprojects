using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Timebetaling2
{
    public partial class Form1 : Form
    {
        private const double Hour = 230; // What you earn per hour
        private const double Minute = Hour/60;
        private const double Second = Minute/60;
        private const double Ms = Second/1000;
        double _sum = 0;

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(10);

                _sum += Ms*10;

                AppendTextBox("" + _sum);
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke((MethodInvoker) delegate
                        {
                            label1.Text = "" + _sum;
                        });
                }
                catch
                {
                    //To prevent fuckup during shutdown
                }
                return;
            }
            label1.Text += value;
        }
    }
}
