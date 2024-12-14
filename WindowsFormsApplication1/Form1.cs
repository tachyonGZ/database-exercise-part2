using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void butEnter_Click(object sender, EventArgs e)
		{
			string userkind = userkindcmb.Text;
			string userid = textBox1.Text;
			string userpwd = textBox2.Text;
			string userpwddb;
			if (userkind.Length == 0 || userid.Length == 0 || userpwd.Length == 0) MessageBox.Show("输入信息不完整！");
			else
			{
				SqlConnection connection = new SqlConnection(
					@"Data Source=(LocalDB)\MSSQLLocalDB;
					AttachDbFilename=|DataDirectory|\XKGL.mdf;
					Integrated Security=True;
					Connect Timeout=30"
				);
				SqlDataAdapter adapter = new SqlDataAdapter{
					SelectCommand = new SqlCommand(
						"select * from ADMINISTRATOR where ID = " + userid + " and DEPARTMENT = '" + userkind + "' and PASSWORD = '" + userpwd + "'",
						connection
					)
				};
				DataSet ds = new DataSet();
				adapter.Fill(ds);
				if (ds.Tables[0].Rows.Count > 0)
				{
					userpwddb = ds.Tables[0].Rows[0][0].ToString();
					connection.Open();
					if (userkind == "教务处")
					{
						frm_admin frmadmin = new frm_admin{
							strUserid = userid,
							connection_ = connection
						};
						frmadmin.Show();
					}
					if (userkind == "学院")
					{
						frm_school frmschool = new frm_school{
							strUserid = userid,
							connection_ = connection						
						};
						frmschool.Show();
					}
					if (userkind == "学生")
					{
						frm_student frmstudent = new frm_student{
							strUserid = userid,
							connection_ = connection
						};
						frmstudent.Show();
					}

					this.Visible = false;
					textBox1.Text = "";
					textBox2.Text = "";
					userkindcmb.Text = "";
				}
				else MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void butExit_Click(object sender, EventArgs e)
		{
			Application.Exit();               
		}
	}
}
