using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Task_8_Forms_PM01_N3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double sum = 0;
				int index = 0;
				String str = textBox1.Text;
				Regex regex = new Regex(@"(-|)(\d+,\d+|\d+)([eE](-|)\d+|)");

				foreach (Match it in regex.Matches(str))
				{
					if (it.Success)
					{
						sum += Convert.ToDouble(it.Value);
						index++;
					}
				}
				if (index == 0)
				{
					textBox2.Text = String.Format("В тексте нет чисел");
					return;
				}
				textBox2.Text = sum.ToString();
			}
			catch
			{
				textBox3.Text = String.Format("Что-то пошло не так");
			}
		}	
	}
}
