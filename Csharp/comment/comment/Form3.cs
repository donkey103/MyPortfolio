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
	public partial class frmUpdate : Form
	{
		private string initialID;	//수정하기 전 아이디

		public frmUpdate(ListView.SelectedListViewItemCollection lstitem)
		{
			InitializeComponent();
			ListViewItem item = lstitem[0];
			txtUpdateID.Text = item.SubItems[1].Text;		// id
			txtUpdatePassword.Text = item.SubItems[2].Text;	// 비밀번호
			txtUpdateName.Text = item.SubItems[3].Text;		// 이름
			txtUpdateAge.Text = item.SubItems[4].Text;		// 나이
			chkUpdateMarried.Checked = item.SubItems[5].Text.Equals("y");	// 결혼 유무가 y면 true
			rtxtUpdateComment.Text = item.SubItems[6].Text; // 비고
			initialID = txtUpdateID.Text;
		}

		private void btnUpdateSave_Click(object sender, EventArgs e)
		{
			char is_married = chkUpdateMarried.Checked ? 'y' : 'n';

			string sql = "";
			sql += " update users set ";
			sql += " userid = '" + txtUpdateID.Text + "', ";
			sql += " passwd = '" + txtUpdatePassword.Text + "', ";
			sql += " name = '" + txtUpdateName.Text + "', ";
			sql += " age = '" + txtUpdateAge.Text + "', ";
			sql += " married = '" + is_married + "', ";
			sql += " comment = '" + rtxtUpdateComment.Text + "' ";
			sql += " where userid = '" + initialID + "' ";

			//DB연결

			DBconnection db = new DBconnection();
			int rtn =db.Execute(sql);
			CommonClass.rtnValue(rtn);

			// 데이터 변경 플래그를 true로 만들고
			//창을 닫는다
			CommonClass.form1_datachanged = true;
			this.Close();
		}

		private void btnUpdateDelete_Click(object sender, EventArgs e)
		{
			string sqlconn = "Server=localhost;Database=iotdb;Uid=root;Pwd=wjdqhqhdksrhk;";
			MySqlConnection conn = new MySqlConnection(sqlconn);
			string sql = "DELETE FROM users WHERE userid = '" + txtUpdateID.Text+"'";
			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				int rtn = cmd.ExecuteNonQuery();
				if (rtn > 0)
					MessageBox.Show("성공적으로 삭제되었습니다.");
				else
					MessageBox.Show("데이터가 존재하지 않습니다");
			}
			catch
			{
				MessageBox.Show("연결에러");
			}
			finally
			{
				conn.Close();
			}
			//변경 플래그를 true로 하고
			//창을 닫는다
			CommonClass.form1_datachanged = true;
			Close();

		}

		private void chkUpdateMarried_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void frmUpdate_Load(object sender, EventArgs e)
		{

		}
	}
}
