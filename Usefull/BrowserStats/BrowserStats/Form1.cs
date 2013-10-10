using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BrowserStats
{
    public partial class Form1 : Form
    {
        private double percentage = 0.0;
        List<Browser> browsere = new List<Browser>(); 
        public Form1()
        {
            InitializeComponent();

            
        }

        public void LagGraph()
        {
            browsere.Clear();
            StreamReader sr = new StreamReader("browsere2.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var temp = line.Split(',');
                double per = Double.Parse(temp[1], System.Globalization.CultureInfo.InvariantCulture);
                Browser b;
                if (per <= percentage) continue;
                if ((b = browsere.Find(x => x.Name.Equals(temp[0].Substring(0, temp[0].IndexOf(' '))))) == null)
                {
                    browsere.Add(new Browser()
                    {
                        Name = temp[0].Substring(0, temp[0].IndexOf(' ')),
                        Version = temp[0].Substring(temp[0].LastIndexOf(' ') + 1),
                        percent = per
                    });

                }
                else
                {
                    b = browsere.Find(x => x.Name.Equals(temp[0].Substring(0, temp[0].IndexOf(' '))));
                    if (b != null)
                    {
                        b.percent += per;
                        try
                        {
                            double a = Double.Parse(temp[0].Substring(temp[0].LastIndexOf(' ') + 1),
                                                    System.Globalization.CultureInfo.InvariantCulture);
                            double c = Double.Parse(b.Version, System.Globalization.CultureInfo.InvariantCulture);

                            if (a < c)
                            {
                                b.Version = "" + a;
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                }
            }



            
            ChartArea chartArea1 = new ChartArea();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(chartArea1);
            Series series1 = new Series();
            // series1.LegendText = "Registrerte besøkende";
            series1.IsValueShownAsLabel = true;
            series1.ChartType = SeriesChartType.Bar;
            foreach (var browser in browsere)
            {
                series1.Points.Add(browser.percent).AxisLabel = browser.Name + " " + browser.Version;
            }

            double temps = 0.0;
            foreach (var browser in browsere)
            {
                temps += browser.percent;
            }
            series1.Points.Add(temps).AxisLabel = "Alle";
            chart1.Series.Clear();
            chart1.Series.Add(series1);
            chart1.Titles.Clear();
            chart1.Titles.Add(new Title("Nettlesere", new Docking(), new Font("", 9, FontStyle.Bold), Color.Black));
            chart1.ChartAreas[0].AxisX.Interval = 1; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (x.Contains(','))
            {
                x = x.Replace(',', '.');
            }

            percentage = Double.Parse(x, System.Globalization.CultureInfo.InvariantCulture);
            LagGraph();
        }
    }
}
