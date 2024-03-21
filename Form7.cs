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
	public partial class Form7 : Form
	{
		public Form7()
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

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_login(object sender, EventArgs e)
		{
			// Define the correct username and password
			string correctUsername = "Owner123";
			string correctPassword = "SqueakyClean!";

			// Get the entered username and password
			string enteredUsername = textBox1.Text;
			string enteredPassword = textBox2.Text;

			// Check if the entered username and password are correct
			if (enteredUsername == correctUsername && enteredPassword == correctPassword)
			{
				// If the login is successful, navigate to Form8
				Form8 form8 = new Form8();
				form8.Show();
				this.Hide();
			}
			else
			{
				// If the login fails, show an error message
				MessageBox.Show("Invalid username or password. Please try again.", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}