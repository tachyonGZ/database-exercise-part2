namespace WindowsFormsApplication1
{
    partial class frm_school
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1_s_note = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1_s_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1_s_id = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn2_4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn4_4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn4_5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox5_sc_score = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5_c_id = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5_s_id = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox6_password = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Location = new System.Drawing.Point(2, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1230, 456);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1_s_note);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.textBox1_s_name);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.textBox1_s_id);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(1222, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "学生信息录入";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 20F);
			this.button1.Location = new System.Drawing.Point(456, 301);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(243, 79);
			this.button1.TabIndex = 6;
			this.button1.Text = "保存";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1_s_note
			// 
			this.textBox1_s_note.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox1_s_note.Location = new System.Drawing.Point(297, 200);
			this.textBox1_s_note.Name = "textBox1_s_note";
			this.textBox1_s_note.Size = new System.Drawing.Size(760, 53);
			this.textBox1_s_note.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 20F);
			this.label4.Location = new System.Drawing.Point(74, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(217, 40);
			this.label4.TabIndex = 4;
			this.label4.Text = "其他信息：";
			// 
			// textBox1_s_name
			// 
			this.textBox1_s_name.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox1_s_name.Location = new System.Drawing.Point(297, 116);
			this.textBox1_s_name.Name = "textBox1_s_name";
			this.textBox1_s_name.Size = new System.Drawing.Size(227, 53);
			this.textBox1_s_name.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 20F);
			this.label3.Location = new System.Drawing.Point(74, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(217, 40);
			this.label3.TabIndex = 2;
			this.label3.Text = "学生姓名：";
			// 
			// textBox1_s_id
			// 
			this.textBox1_s_id.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox1_s_id.Location = new System.Drawing.Point(297, 30);
			this.textBox1_s_id.Name = "textBox1_s_id";
			this.textBox1_s_id.Size = new System.Drawing.Size(227, 53);
			this.textBox1_s_id.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 20F);
			this.label2.Location = new System.Drawing.Point(74, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 40);
			this.label2.TabIndex = 0;
			this.label2.Text = "学生学号：";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(1222, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "选课查询";
			this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dataGridViewCheckBoxColumn2_4});
			this.dataGridView2.Location = new System.Drawing.Point(7, 7);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 62;
			this.dataGridView2.RowTemplate.Height = 30;
			this.dataGridView2.Size = new System.Drawing.Size(1208, 410);
			this.dataGridView2.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn2_1
			// 
			this.dataGridViewTextBoxColumn2_1.HeaderText = "SID";
			this.dataGridViewTextBoxColumn2_1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_1.Name = "dataGridViewTextBoxColumn2_1";
			this.dataGridViewTextBoxColumn2_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn2_1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2_2
			// 
			this.dataGridViewTextBoxColumn2_2.HeaderText = "CID";
			this.dataGridViewTextBoxColumn2_2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_2.Name = "dataGridViewTextBoxColumn2_2";
			this.dataGridViewTextBoxColumn2_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2_2.Width = 150;
			// 
			// dataGridViewTextBoxColumn2_3
			// 
			this.dataGridViewTextBoxColumn2_3.HeaderText = "DATE";
			this.dataGridViewTextBoxColumn2_3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2_3.Name = "dataGridViewTextBoxColumn2_3";
			this.dataGridViewTextBoxColumn2_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn2_3.Width = 150;
			// 
			// dataGridViewCheckBoxColumn2_4
			// 
			this.dataGridViewCheckBoxColumn2_4.HeaderText = "DELAPP";
			this.dataGridViewCheckBoxColumn2_4.MinimumWidth = 8;
			this.dataGridViewCheckBoxColumn2_4.Name = "dataGridViewCheckBoxColumn2_4";
			this.dataGridViewCheckBoxColumn2_4.ReadOnly = true;
			this.dataGridViewCheckBoxColumn2_4.Width = 150;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridView3);
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new System.Drawing.Size(1222, 424);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "课程信息查询";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AllowUserToOrderColumns = true;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.dataGridView3.Location = new System.Drawing.Point(7, 7);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.RowHeadersWidth = 62;
			this.dataGridView3.RowTemplate.Height = 30;
			this.dataGridView3.Size = new System.Drawing.Size(1208, 410);
			this.dataGridView3.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "CLASSROOM";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "TEACHER";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "TIME";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 150;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "PRECOURSE";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 150;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "CREDIT";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 150;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "NOTE";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 150;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.dataGridView4);
			this.tabPage4.Location = new System.Drawing.Point(4, 28);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage4.Size = new System.Drawing.Size(1222, 424);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "学生信息查询";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// dataGridView4
			// 
			this.dataGridView4.AllowUserToAddRows = false;
			this.dataGridView4.AllowUserToDeleteRows = false;
			this.dataGridView4.AllowUserToOrderColumns = true;
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4_1,
            this.dataGridViewTextBoxColumn4_2,
            this.dataGridViewTextBoxColumn4_3,
            this.dataGridViewCheckBoxColumn4_4,
            this.dataGridViewCheckBoxColumn4_5});
			this.dataGridView4.Location = new System.Drawing.Point(7, 7);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.ReadOnly = true;
			this.dataGridView4.RowHeadersWidth = 62;
			this.dataGridView4.RowTemplate.Height = 30;
			this.dataGridView4.Size = new System.Drawing.Size(1208, 410);
			this.dataGridView4.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn4_1
			// 
			this.dataGridViewTextBoxColumn4_1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn4_1.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4_1.Name = "dataGridViewTextBoxColumn4_1";
			this.dataGridViewTextBoxColumn4_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn4_1.Width = 150;
			// 
			// dataGridViewTextBoxColumn4_2
			// 
			this.dataGridViewTextBoxColumn4_2.HeaderText = "NAME";
			this.dataGridViewTextBoxColumn4_2.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4_2.Name = "dataGridViewTextBoxColumn4_2";
			this.dataGridViewTextBoxColumn4_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn4_2.Width = 150;
			// 
			// dataGridViewTextBoxColumn4_3
			// 
			this.dataGridViewTextBoxColumn4_3.HeaderText = "NOTE";
			this.dataGridViewTextBoxColumn4_3.MinimumWidth = 8;
			this.dataGridViewTextBoxColumn4_3.Name = "dataGridViewTextBoxColumn4_3";
			this.dataGridViewTextBoxColumn4_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn4_3.Width = 150;
			// 
			// dataGridViewCheckBoxColumn4_4
			// 
			this.dataGridViewCheckBoxColumn4_4.HeaderText = "SUSPENDED";
			this.dataGridViewCheckBoxColumn4_4.MinimumWidth = 8;
			this.dataGridViewCheckBoxColumn4_4.Name = "dataGridViewCheckBoxColumn4_4";
			this.dataGridViewCheckBoxColumn4_4.ReadOnly = true;
			this.dataGridViewCheckBoxColumn4_4.Width = 150;
			// 
			// dataGridViewCheckBoxColumn4_5
			// 
			this.dataGridViewCheckBoxColumn4_5.HeaderText = "REGISTERED";
			this.dataGridViewCheckBoxColumn4_5.MinimumWidth = 8;
			this.dataGridViewCheckBoxColumn4_5.Name = "dataGridViewCheckBoxColumn4_5";
			this.dataGridViewCheckBoxColumn4_5.ReadOnly = true;
			this.dataGridViewCheckBoxColumn4_5.Width = 150;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.button5);
			this.tabPage5.Controls.Add(this.textBox5_sc_score);
			this.tabPage5.Controls.Add(this.label5);
			this.tabPage5.Controls.Add(this.textBox5_c_id);
			this.tabPage5.Controls.Add(this.label6);
			this.tabPage5.Controls.Add(this.textBox5_s_id);
			this.tabPage5.Controls.Add(this.label7);
			this.tabPage5.Location = new System.Drawing.Point(4, 28);
			this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage5.Size = new System.Drawing.Size(1222, 424);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "成绩录入";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("宋体", 20F);
			this.button5.Location = new System.Drawing.Point(502, 308);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(243, 79);
			this.button5.TabIndex = 13;
			this.button5.Text = "保存";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// textBox5_sc_score
			// 
			this.textBox5_sc_score.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox5_sc_score.Location = new System.Drawing.Point(581, 212);
			this.textBox5_sc_score.Name = "textBox5_sc_score";
			this.textBox5_sc_score.Size = new System.Drawing.Size(278, 53);
			this.textBox5_sc_score.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 20F);
			this.label5.Location = new System.Drawing.Point(358, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(217, 40);
			this.label5.TabIndex = 11;
			this.label5.Text = "课程成绩：";
			// 
			// textBox5_c_id
			// 
			this.textBox5_c_id.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox5_c_id.Location = new System.Drawing.Point(581, 128);
			this.textBox5_c_id.Name = "textBox5_c_id";
			this.textBox5_c_id.Size = new System.Drawing.Size(278, 53);
			this.textBox5_c_id.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 20F);
			this.label6.Location = new System.Drawing.Point(358, 131);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 40);
			this.label6.TabIndex = 9;
			this.label6.Text = "课程号：";
			// 
			// textBox5_s_id
			// 
			this.textBox5_s_id.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox5_s_id.Location = new System.Drawing.Point(581, 42);
			this.textBox5_s_id.Name = "textBox5_s_id";
			this.textBox5_s_id.Size = new System.Drawing.Size(278, 53);
			this.textBox5_s_id.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 20F);
			this.label7.Location = new System.Drawing.Point(358, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(217, 40);
			this.label7.TabIndex = 7;
			this.label7.Text = "学生学号：";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.button6);
			this.tabPage6.Controls.Add(this.textBox6_password);
			this.tabPage6.Controls.Add(this.label8);
			this.tabPage6.Location = new System.Drawing.Point(4, 28);
			this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage6.Size = new System.Drawing.Size(1222, 424);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "密码修改";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("宋体", 20F);
			this.button6.Location = new System.Drawing.Point(505, 263);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(189, 66);
			this.button6.TabIndex = 16;
			this.button6.Text = "保存";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox6_password
			// 
			this.textBox6_password.Font = new System.Drawing.Font("宋体", 20F);
			this.textBox6_password.Location = new System.Drawing.Point(584, 125);
			this.textBox6_password.Name = "textBox6_password";
			this.textBox6_password.Size = new System.Drawing.Size(368, 53);
			this.textBox6_password.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 20F);
			this.label8.Location = new System.Drawing.Point(304, 128);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(257, 40);
			this.label8.TabIndex = 14;
			this.label8.Text = "请输入密码：";
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.button7);
			this.tabPage7.Controls.Add(this.label1);
			this.tabPage7.Location = new System.Drawing.Point(4, 28);
			this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage7.Size = new System.Drawing.Size(1222, 424);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "退出";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(512, 141);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(112, 34);
			this.button7.TabIndex = 1;
			this.button7.Text = "确定";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(266, 148);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "您确定要退出吗？";
			// 
			// frm_school
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1233, 512);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_school";
			this.Text = "frm_school";
			this.Load += new System.EventHandler(this.frm_school_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1_s_note;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1_s_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1_s_id;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox5_sc_score;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5_c_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5_s_id;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox6_password;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2_3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2_4;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4_1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4_2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4_3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4_4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4_5;
	}
}