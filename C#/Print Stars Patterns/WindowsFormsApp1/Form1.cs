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
		int d, i, j, n, p, k;
		string a = "*", b = " ";
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
				
					n = Convert.ToInt32(Data1Numeric.Value);
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
				case 1:
					n = Convert.ToInt32(Data1Numeric.Value);
					d = n;
					for (i = 1; i< n; i++)
					{
						for (j = 1; j<d; j++)
						{
							showPatternTXT.Text += a;
						}
						d--;
						showPatternTXT.Text += "\r\n";
					}
					break;
			}

		}
	
		private void patternsCMB_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (patternsCMB.SelectedIndex)
			{
				case 0:
					Data1LBL.Text = "Enter the height of the Christmas tree";
					break;
				case 1:
					Data1LBL.Text = "Square";
					break;
				case 2:
					Data1LBL.Text = "Rectangle";
					break;
				case 3:
					Data1LBL.Text = "Star";
					break;
				case 4:
					Data1LBL.Text = "Triangle";
					break;
				case 5:
					Data1LBL.Text = "Diamond";
					break;
			}
		}
	}
}
