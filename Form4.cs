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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btn_Pay(object sender, EventArgs e)
		{
			// Simulate processing the payment
			bool paymentSuccessful = ProcessPayment();

			if (paymentSuccessful)
			{
				// If the payment was successful, reset the form
				ResetForm();

				// Show a success message
				MessageBox.Show("Payment successful! A security deposit of $30 has been charged.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				// If the payment failed, show an error message
				MessageBox.Show("Payment failed. Please try again.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ProcessPayment()
		{
			// Simulate a successful payment
			return true;
		}

		private void ResetForm()
		{
			// Clear the textboxes
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";

			// Reset the date picker to the current date
			dateTimePicker1.Value = DateTime.Now;

		}
	}
}

