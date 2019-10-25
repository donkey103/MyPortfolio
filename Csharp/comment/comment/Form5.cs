using MySql.Data.MySqlClient;
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
	public partial class frmComment : Form
	{
		public frmComment()
		{
			InitializeComponent();
		}

		private void Form5_Load(object sender, EventArgs e)
		{
			lstComment.Columns.Add("빈칸", 0);
			lstComment.Columns.Add("ID", 100);
			lstComment.Columns.Add("작성자ID", 100);
			lstComment.Columns.Add("작성자이름", 100);
			lstComment.Columns.Add("댓글", 400);
		}

		private void btnCmtSelect_Click(object sender, EventArgs e)
		{
			String sql = "SELECT c.id, c.commenter, u.name, c.comment ";
			sql += " FROM comment AS c INNER JOIN users AS u ";
			sql += " ON c.commenter = u.userid ORDER BY id ASC ";
			lstComment.Items.Clear();
			DBconnection db = new DBconnection();
			lstComment =  db.Select(sql, lstComment, 4);

			lstComment.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			lstComment.View = View.Details;
			lstComment.FullRowSelect = true;
			lstComment.GridLines = true;

		}

		private void btnCmtInsert_Click(object sender, EventArgs e)
		{
			frmAddCmt Form6 = new frmAddCmt();
			Form6.StartPosition = FormStartPosition.CenterScreen;
			Form6.Show();
		}

		private void btnCmtUpdate_Click(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection item = lstComment.SelectedItems;

			try
			{
				frmChangeComment ccform = new frmChangeComment(item);
				ccform.StartPosition = FormStartPosition.CenterScreen;
				ccform.Show();
			}
			catch
			{
				MessageBox.Show("항목을 선택하십시오");
			}
		}

		private void btnCmtDelete_Click(object sender, EventArgs e)
		{
			MessageBox.Show("삭제버튼 개발중");
		}

		private void btnCmtQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void lstComment_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnCmtSearch_Click(object sender, EventArgs e)
		{

		}

		private void frmComment_Activated(object sender, EventArgs e)
		{
			if (CommonClass.form2_datachanged == true)
				btnCmtSelect_Click(sender, e);
			CommonClass.form2_datachanged = false;
		}
	}
}
