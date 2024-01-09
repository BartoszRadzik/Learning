using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CloseBTN_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void PrintBTN_Click(object sender, EventArgs e)
		{
			showPatternTXT.Text = "";
			switch (patternsCMB.SelectedIndex) { 
				case 0:
					//showPatternTXT.Text = "test";
					int d, i, j, n, p, k;
					string a, b;
					n = 6;
					a = "*";
					b = " ";
					d = n;
					for (i = 1; i <= n; i++)
					{
						for (j = 1; j < d; j++)
						{
							showPatternTXT.Text += b;
						}
						for (p = 1; p <= i; p++)
						{
							showPatternTXT.Text += a;
						}
						for (k = 1; k <= i - 1; k++)
						{
							showPatternTXT.Text += a;
						}
						d--;
						showPatternTXT.Text += "\r\n";
					}
					break;
			}

		}
	}
}
