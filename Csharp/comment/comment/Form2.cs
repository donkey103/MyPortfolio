using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace comment
{
	public partial class frmInsert : Form
	{
		public frmInsert()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnAddSave_Click(object sender, EventArgs e)
		{
			//쿼리문 생성
			char is_married = chkAddMarried.Checked ? 'y' : 'n';
			string sql = "";
			sql += " INSERT INTO users(userid, passwd, name, age, married, comment) values( ";
			sql += " '" + txtAddID.Text + "', ";
			sql += " '" + txtAddPassword.Text + "', ";
			sql += " '" + txtAddName.Text + "', ";
			sql += " '" + txtAddAge.Text + "', ";
			sql += " '" + is_married + "', ";
			sql += " '" + rtxtAddComment.Text + "'); ";

			Console.WriteLine(sql);

			//db입력부분

			//DB연결
			string sqlconn = "Server=localhost;Database=iotdb;Uid=root;Pwd=wjdqhqhdksrhk;";
			MySqlConnection conn = new MySqlConnection(sqlconn);
			conn.Open();
			if (conn == null)
			{
				MessageBox.Show("연결에러");
			}
			else
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand(sql, conn);
					int rtn = cmd.ExecuteNonQuery();
				}
				catch
				{
					MessageBox.Show("쿼리실행중 에러발생");
				}
			}
			conn.Close();

			//데이터 변경 플래그를 true로 바꾸고
			//현재 창을 닫는다
			CommonClass.form1_datachanged = true;
			this.Close();
		}

		
	}
}
