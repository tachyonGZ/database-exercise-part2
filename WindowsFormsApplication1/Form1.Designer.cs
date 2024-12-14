using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.butEnter = new System.Windows.Forms.Button();
			this.butExit = new System.Windows.Forms.Button();
			this.userkindcmb = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("SimSun", 12F);
			this.textBox1.Location = new System.Drawing.Point(96, 122);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("SimSun", 12F);
			this.textBox2.Location = new System.Drawing.Point(96, 154);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(100, 26);
			this.textBox2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SimSun", 12F);
			this.label1.Location = new System.Drawing.Point(60, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "欢迎进入选课管理系统";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("SimSun", 12F);
			this.label2.Location = new System.Drawing.Point(40, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("SimSun", 12F);
			this.label3.Location = new System.Drawing.Point(40, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "密码";
			// 
			// butEnter
			// 
			this.butEnter.Font = new System.Drawing.Font("SimSun", 12F);
			this.butEnter.Location = new System.Drawing.Point(43, 215);
			this.butEnter.Name = "butEnter";
			this.butEnter.Size = new System.Drawing.Size(75, 23);
			this.butEnter.TabIndex = 5;
			this.butEnter.Text = "登录";
			this.butEnter.UseVisualStyleBackColor = true;
			this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
			// 
			// butExit
			// 
			this.butExit.Font = new System.Drawing.Font("SimSun", 12F);
			this.butExit.Location = new System.Drawing.Point(153, 215);
			this.butExit.Name = "butExit";
			this.butExit.Size = new System.Drawing.Size(75, 23);
			this.butExit.TabIndex = 6;
			this.butExit.Text = "退出";
			this.butExit.UseVisualStyleBackColor = true;
			this.butExit.Click += new System.EventHandler(this.butExit_Click);
			// 
			// userkindcmb
			// 
			this.userkindcmb.FormattingEnabled = true;
			this.userkindcmb.Items.AddRange(new object[] {
			"教务处",
			"学院",
			"学生"});
			this.userkindcmb.Location = new System.Drawing.Point(75, 78);
			this.userkindcmb.Name = "userkindcmb";
			this.userkindcmb.Size = new System.Drawing.Size(133, 20);
			this.userkindcmb.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 257);
			this.Controls.Add(this.userkindcmb);
			this.Controls.Add(this.butExit);
			this.Controls.Add(this.butEnter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butEnter;
		private System.Windows.Forms.Button butExit;
		private System.Windows.Forms.ComboBox userkindcmb;
	}
}