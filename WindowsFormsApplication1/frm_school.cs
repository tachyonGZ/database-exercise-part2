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
    public partial class frm_school : Form
    {

        public string strUserid;
		public SqlConnection connection_;

        public frm_school()
        {
            InitializeComponent();
        }

        private void frm_school_Load(object sender, EventArgs e)
        {

        }

		private void button7_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE AddStu {0}, '{1}', '{2}';", 
					int.Parse(textBox1_s_id.Text),
					textBox1_s_name.Text,
					textBox1_s_note.Text
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (1 == tabControl1.SelectedIndex)
			{
				while (dataGridView2.Rows.Count != 0) dataGridView2.Rows.RemoveAt(0);
				SqlDataAdapter adapter = new SqlDataAdapter{
					SelectCommand = new SqlCommand("EXECUTE QuerySC;", connection_)
				};
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					int index = dataGridView2.Rows.Add();
					((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[0]).Value = ds.Tables[0].Rows[i][0].ToString();
					((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[1]).Value = ds.Tables[0].Rows[i][1].ToString();
					((DataGridViewTextBoxCell)dataGridView2.Rows[index].Cells[2]).Value = ds.Tables[0].Rows[i][2].ToString();
				}
				return;
			}
			if (2 == tabControl1.SelectedIndex)
			{
				while (dataGridView3.Rows.Count != 0) dataGridView3.Rows.RemoveAt(0);
				SqlDataAdapter adapter = new SqlDataAdapter{
					SelectCommand = new SqlCommand("EXECUTE QueryCourse;", connection_)
				};
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					int index = dataGridView3.Rows.Add();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[0]).Value = ds.Tables[0].Rows[i][0].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[1]).Value = ds.Tables[0].Rows[i][1].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[2]).Value = ds.Tables[0].Rows[i][2].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[3]).Value = ds.Tables[0].Rows[i][3].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[4]).Value = ds.Tables[0].Rows[i][4].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[5]).Value = ds.Tables[0].Rows[i][5].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[6]).Value = ds.Tables[0].Rows[i][6].ToString();
					((DataGridViewTextBoxCell)dataGridView3.Rows[index].Cells[7]).Value = ds.Tables[0].Rows[i][7].ToString();
				}
				return;
			}
			if (3 == tabControl1.SelectedIndex)
			{
				while (dataGridView4.Rows.Count != 0) dataGridView4.Rows.RemoveAt(0);
				SqlDataAdapter adapter = new SqlDataAdapter{ 
					SelectCommand = new SqlCommand("EXECUTE QueryStu;", connection_)
				};
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					int index = dataGridView4.Rows.Add();
					((DataGridViewTextBoxCell)dataGridView4.Rows[index].Cells[0]).Value = ds.Tables[0].Rows[i][0].ToString();
					((DataGridViewTextBoxCell)dataGridView4.Rows[index].Cells[1]).Value = ds.Tables[0].Rows[i][1].ToString();
					((DataGridViewTextBoxCell)dataGridView4.Rows[index].Cells[2]).Value = ds.Tables[0].Rows[i][2].ToString();
					((DataGridViewCheckBoxCell)dataGridView4.Rows[index].Cells[3]).Value = ds.Tables[0].Rows[i][3].ToString() == "True";
					((DataGridViewCheckBoxCell)dataGridView4.Rows[index].Cells[4]).Value = ds.Tables[0].Rows[i][4].ToString() == "True";
				}
				return;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE SchoolUpdateScore {0}, {1}, {2};", 
					int.Parse(textBox5_s_id.Text),
					int.Parse(textBox5_c_id.Text),
					short.Parse(textBox5_sc_score.Text)
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand(
				string.Format(
					"EXECUTE SchoolChangePwd '{0}', '{1}';",
					strUserid,
					textBox6_password.Text
				),
				connection_
			);
			cmd.ExecuteNonQuery();
		}
	}
}
