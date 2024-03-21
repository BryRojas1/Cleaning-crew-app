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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btn_Submit(object sender, EventArgs e)
		{
			// Show the message box
			MessageBox.Show("Form has been submitted.", "Submission Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Reset the textboxes
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";

			// Uncheck the checkboxes
			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
		}
	}
}