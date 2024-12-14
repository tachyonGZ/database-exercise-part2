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
    public partial class frm_student : Form
    {
        public string strUserid;
		public SqlConnection connection_;

        public frm_student()
        {
            InitializeComponent();
        }

		private void button5_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE StuAddCourse {0}, {1};", 
					int.Parse(strUserid),
					int.Parse(textBox1_c_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE StuCancelCourse {0}, {1};", 
					int.Parse(strUserid),
					int.Parse(textBox3_c_id.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE StuChangePwd '{0}', '{1}';", 
					strUserid,
					textBox4_password.Text
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedIndex)
			{
				case 1:
					while (dataGridView2.Rows.Count != 0) dataGridView2.Rows.RemoveAt(0);
					SqlDataAdapter adapter = new SqlDataAdapter{ 
						SelectCommand = new SqlCommand(
							string.Format(
								"EXECUTE StuQuerySC {0};",
								int.Parse(strUserid)
							),
							connection_
						)
					};
					DataSet ds = new DataSet();
					adapter.Fill(ds);
					for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
					{
						int index = dataGridView2.Rows.Add();
						((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[0]).Value = ds.Tables[0].Rows[i][0].ToString();
						((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[1]).Value = ds.Tables[0].Rows[i][1].ToString();
						((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[2]).Value = ds.Tables[0].Rows[i][2].ToString();
						((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[3]).Value = ds.Tables[0].Rows[i][3].ToString();
					}
					break;
			}
		}
	}
}
