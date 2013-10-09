using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiTest
{
    public partial class Form1 : Form
    {
        VerticalProgressBar vert;
        int last = 0;
        Boolean opp = true;
        public Form1()
        {
            InitializeComponent();

            progressBar1.Name = "ProgresBar1";
            progressBar1.Minimum = 0;

            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.Red;
            
            vert = new VerticalProgressBar();

            vert.Location = new System.Drawing.Point(0, 30);

            vert.Name = "progressBar1";

            vert.Width = 30;

            vert.Height = 370;
            vert.Minimum = 0;
            vert.Maximum = 100;
            vert.ForeColor = Color.FromArgb(255, 0, 0);
            vert.BackColor = Color.FromArgb(150, 0, 0);

            Controls.Add(vert);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Trykk ");
            numericUpDown1.Value++;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                vert.Value += 1;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (last > (int)numericUpDown1.Value)
            {
                richTextBox1.AppendText("NED ");
            }
            else
            {
                richTextBox1.AppendText("OPP ");

            }
            last = (int)numericUpDown1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opp)
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 1;
                    vert.Value += 1;
                }
                else
                {
                    opp = false;
                }
            }
            else
            {
                progressBar1.Value = 0;
                vert.Value = 0;
                    opp = true;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
        }
    }
}
