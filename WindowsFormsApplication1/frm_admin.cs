using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class frm_admin : Form
	{
		public string strUserid;
		public SqlConnection connection_;

		public frm_admin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE AddCourse {0}, '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}';", 
					int.Parse(textBox1_c_id.Text),
					textBox1_c_name.Text,
					textBox1_c_classroom.Text,
					textBox1_c_teacher.Text,
					textBox1_c_time.Text,
					int.Parse(textBox1_c_precourse.Text),
					short.Parse(textBox1_c_credit.Text),
					textBox1_c_note.Text
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button4_1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE SuspendStu {0};", 
					int.Parse(textBox4_1_s_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button4_2_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE UnsuspendStu {0};", 
					int.Parse(textBox4_2_s_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE AdminCancelCourse {0}, {1};", 
					int.Parse(textBox3_s_id.Text),
					int.Parse(textBox3_c_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE AdminDropStu {0};", 
					int.Parse(textBox2_s_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE AdminRegStu {0};", 
					int.Parse(textBox5_s_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE AdminChangePwd '{0}', '{1}';",
					strUserid,
					textBox6_password.Text
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}
	}
}
