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
	public partial class frmAddCmt : Form
	{
		public frmAddCmt()
		{
			InitializeComponent();
		}

		private void Form6_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnAddCmtSave_Click(object sender, EventArgs e)
		{
			string sql = "INSERT INTO comment(commenter, comment) VALUES ( ";
			sql += " '" + txtAddCmtID.Text + "', ";
			sql +=" '" + txtAddCmtComment.Text + "') ";
			DBconnection dbex = new DBconnection();
			int rtn = dbex.Execute(sql);

			if (rtn > 0)
			{   //입력이 완료되면 창을 닫는다
				MessageBox.Show("추가 되었습니다");
				CommonClass.form2_datachanged = true;
				Close();	
			}
			else
				MessageBox.Show("에러가 발생했습니다");
		}
	}
}
