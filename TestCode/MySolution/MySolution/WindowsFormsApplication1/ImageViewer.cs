using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class ImageViewer : Form
	{
		public ImageViewer()
		{
			InitializeComponent();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			DialogResult res = openFileDialog1.ShowDialog();

			if (res == DialogResult.OK)
			{

				string filename = openFileDialog1.FileName;
				pictureBox1.Load(filename);
			}
		}
	}
}
