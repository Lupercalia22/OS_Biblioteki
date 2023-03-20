using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibr;

namespace OS_Bib
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBox1.Text = Convert.ToString(MyLibr.MyLibr.Add(14,7));
		}
	}
}
