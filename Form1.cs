using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaning_APP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}
		private void button1_Click(object sender, EventArgs e)
		{
			// Open the next form when button1 is clicked
			Form3 form3 = new Form3();
			form3.Show();
			this.Hide();
		}
			private void button2_Click(object sender, EventArgs e)
		{
			// Open the next form when button2 is clicked
			Form2 form2 = new Form2();
			form2.Show();
			this.Hide();
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void btn_Employer(object sender, EventArgs e)
		{
			Form7 form7 = new Form7();
			form7.Show();
			this.Hide();
		}
	}
}
