namespace WindowsFormsApplication1
{
    partial class frm_student
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1_c_id = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3_c_id = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox4_password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(4, 4);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1090, 466);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1_c_id);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage1.Size = new System.Drawing.Size(1082, 434);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "选课";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage2.Size = new System.Drawing.Size(1082, 434);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "选课查询";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button3);
			this.tabPage3.Controls.Add(this.textBox3_c_id);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage3.Size = new System.Drawing.Size(1082, 434);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "退课请求";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button4);
			this.tabPage4.Controls.Add(this.textBox4_password);
			this.tabPage4.Controls.Add(this.label3);
			this.tabPage4.Location = new System.Drawing.Point(4, 28);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage4.Size = new System.Drawing.Size(1082, 434);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "密码修改";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.button5);
			this.tabPage5.Controls.Add(this.label1);
			this.tabPage5.Location = new System.Drawing.Point(4, 28);
			this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage5.Size = new System.Drawing.Size(1082, 434);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "退出";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(604, 128);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 34);
			this.button5.TabIndex = 1;
			this.button5.Text = "确定";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(358, 135);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "您确定要退出吗？";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 20F);
			this.button1.Location = new System.Drawing.Point(418, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(189, 66);
			this.button1.TabIndex = 19;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1_c_id
			// 
			this.textBox1_c_id.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox1_c_id.Location = new System.Drawing.Point(497, 115);
			this.textBox1_c_id.Name = "textBox1_c_id";
			this.textBox1_c_id.Size = new System.Drawing.Size(368, 53);
			this.textBox1_c_id.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 20F);
			this.label8.Location = new System.Drawing.Point(217, 118);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(177, 40);
			this.label8.TabIndex = 17;
			this.label8.Text = "课程号：";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2_1,
            this.dataGridViewTextBoxColumn2_2,
            this.dataGridViewTextBoxColumn2_3,
            this.dataGridViewTextBoxColumn2_4});
			this.dataGridView2.Location = new System.Drawing.Point(7, 7);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 62;
			this.dataGridView2.RowTemplate.Height = 30;
			this.dataGridView2.Size = new System.Drawing.Size(1068, 420);
			this.dataGridView2.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn2_1
			// 
			this.dataGridViewTextBoxColumn2_1.HeaderText = "SID";
			this.dataGridViewTextBoxColumn2_1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_1.Name = "dataGridViewTextBoxColumn2_1";
			this.dataGridViewTextBoxColumn2_1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2_2
			// 
			this.dataGridViewTextBoxColumn2_2.HeaderText = "CID";
			this.dataGridViewTextBoxColumn2_2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_2.Name = "dataGridViewTextBoxColumn2_2";
			this.dataGridViewTextBoxColumn2_2.Width = 150;
			// 
			// dataGridViewTextBoxColumn2_3
			// 
			this.dataGridViewTextBoxColumn2_3.HeaderText = "DATE";
			this.dataGridViewTextBoxColumn2_3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_3.Name = "dataGridViewTextBoxColumn2_3";
			this.dataGridViewTextBoxColumn2_3.Width = 150;
			// 
			// dataGridViewTextBoxColumn2_4
			// 
			this.dataGridViewTextBoxColumn2_4.HeaderText = "SCORE";
			this.dataGridViewTextBoxColumn2_4.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_4.Name = "dataGridViewTextBoxColumn2_4";
			this.dataGridViewTextBoxColumn2_4.Width = 150;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("宋体", 20F);
			this.button3.Location = new System.Drawing.Point(418, 253);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(189, 66);
			this.button3.TabIndex = 22;
			this.button3.Text = "确定";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3_c_id
			// 
			this.textBox3_c_id.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox3_c_id.Location = new System.Drawing.Point(497, 115);
			this.textBox3_c_id.Name = "textBox3_c_id";
			this.textBox3_c_id.Size = new System.Drawing.Size(368, 53);
			this.textBox3_c_id.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 20F);
			this.label2.Location = new System.Drawing.Point(217, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(297, 40);
			this.label2.TabIndex = 20;
			this.label2.Text = "退课的课程号：";
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("宋体", 20F);
			this.button4.Location = new System.Drawing.Point(418, 253);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(189, 66);
			this.button4.TabIndex = 22;
			this.button4.Text = "确定";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox4_password
			// 
			this.textBox4_password.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox4_password.Location = new System.Drawing.Point(497, 115);
			this.textBox4_password.Name = "textBox4_password";
			this.textBox4_password.Size = new System.Drawing.Size(368, 53);
			this.textBox4_password.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 20F);
			this.label3.Location = new System.Drawing.Point(217, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(257, 40);
			this.label3.TabIndex = 20;
			this.label3.Text = "请输入密码：";
			// 
			// frm_student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 489);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_student";
			this.Text = "frm_student";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1_c_id;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox3_c_id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox4_password;
		private System.Windows.Forms.Label label3;
	}
}