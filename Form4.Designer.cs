﻿
namespace Cleaning_APP
{
	partial class Form4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(336, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Basic Clean";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(226, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(226, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telephone Number:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(226, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Address:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(342, 329);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 36);
			this.button1.TabIndex = 5;
			this.button1.Text = "Payment";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_Pay);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(230, 253);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(299, 29);
			this.dateTimePicker1.TabIndex = 6;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(289, 119);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(203, 29);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(388, 164);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(163, 29);
			this.textBox2.TabIndex = 8;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(309, 207);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 29);
			this.textBox3.TabIndex = 9;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}