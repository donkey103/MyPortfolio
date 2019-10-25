using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comment
{
	public partial class frmChangeComment : Form
	{
		string commentID;	// 키 값으로 사용할 아이디

		public frmChangeComment(ListView.SelectedListViewItemCollection lstitem)
		{
			InitializeComponent();
			ListViewItem item = lstitem[0];
			commentID = item.SubItems[1].Text;	// 문자로 전송된 아이디정보를 정수로 변환
			txtChangeCmtID.Text = item.SubItems[2].Text;
			txtChangeCmtName.Text = item.SubItems[3].Text;
			txtChangeCmtComment.Text = item.SubItems[4].Text;
		}

		private void Form7_Load(object sender, EventArgs e)
		{

		}

		private void btnAddCmtCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAddCmtSave_Click(object sender, EventArgs e)
		{
			string sql = "UPDATE comment SET ";
			sql += " commenter = '" + txtChangeCmtID.Text + "', ";
			sql += " comment = '" + txtChangeCmtComment.Text + "' ";
			sql += " where id = '" + commentID + "' ";
			Console.WriteLine(sql);
			DBconnection updateCmt = new DBconnection();
			int rtn = updateCmt.Execute(sql);
			if (rtn > 0)
			{   //입력이 완료되면 창을 닫는다
				MessageBox.Show("변경 되었습니다");
				CommonClass.form2_datachanged = true;
				Close();
			}
			else
				MessageBox.Show("에러가 발생했습니다");


		}
	}
}
