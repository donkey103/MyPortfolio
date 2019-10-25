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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void btnSelect_Click(object sender, EventArgs e)
		{
			String sql = "Select userid, passwd, name, age, married, comment from users";

			DBconnection db = new DBconnection();

			lstUsers.Items.Clear();
			
			lstUsers = db.Select(sql, lstUsers, 6);
			if(lstUsers == null)
			{
				MessageBox.Show("리스트 에러발생");
			}
			lstUsers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			lstUsers.View = View.Details;
			lstUsers.FullRowSelect = true;
			lstUsers.GridLines = true;

		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			frmInsert Form2 = new frmInsert();
			Form2.StartPosition = FormStartPosition.CenterScreen;
			Form2.Show();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				ListView.SelectedListViewItemCollection item = lstUsers.SelectedItems;

				frmUpdate Form3 = new frmUpdate(item);
				Form3.StartPosition = FormStartPosition.CenterParent;
				Form3.Show();
			}
			catch
			{
				MessageBox.Show("항목을 선택하십시오");
			}
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//선택한 인덱스의 값
			int idxSelected = lstUsers.FocusedItem.Index;
			string selectedItem = lstUsers.Items[idxSelected].SubItems[1].Text;
			string sql = "DELETE FROM users WHERE userid = '" + selectedItem + "'";

			DBconnection deleter = new DBconnection();
			int rtn = deleter.DeleteQuery(CommonClass.Number_of_Table.USER_TABLE, selectedItem);
			// rtn에 따른 결과창 출력
			CommonClass.rtnValue(rtn);
			// 직접 갱신한다
			btnSelect_Click(sender, e);
		}

		private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			frmLogin Form4 = new frmLogin();
			Form4.StartPosition = FormStartPosition.CenterScreen;
			Form4.Show();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lstUsers.Columns.Add("빈칸", 0);
			lstUsers.Columns.Add("아이디", 100);
			lstUsers.Columns.Add("비밀번호(임시출력)", 0);  // 0으로 바꿔야함
			lstUsers.Columns.Add("이름", 100);
			lstUsers.Columns.Add("나이", 100);
			lstUsers.Columns.Add("결혼여부", 100);
			lstUsers.Columns.Add("비교", 400);
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			if (CommonClass.form1_datachanged == true)
			{
				btnSelect_Click(sender, e);
				CommonClass.form1_datachanged = false;
			}

		}
	}
}
