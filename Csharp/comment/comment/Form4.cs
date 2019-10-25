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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnLgnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnLgnOK_Click(object sender, EventArgs e)
		{

			// 아이디와 비밀번호가 올바른지 검증하는 과정은 차후 추가할 예정
			// 이 폼에서는 직접 sql을 입력하지 않고 DBconnection객체를 사용한다

			if (txtLgnID.Text.Equals("") || txtLgnPW.Text.Equals(""))	//값이 입력되지 않은경우
			{
				MessageBox.Show("아이디 또는 비밀번호를 입력하십시오");
			}
			else
			{
				DBconnection confirm = new DBconnection();
				int rtn = confirm.pwdConfirm(txtLgnID.Text, txtLgnPW.Text);
				switch(rtn)
				{
					case 1:
						MessageBox.Show("로그인 성공");
						frmComment Form5 = new frmComment();
						Form5.StartPosition = FormStartPosition.CenterScreen;
						Form5.Show();
						Close();
						break;
					case 0:
						MessageBox.Show("아이디또는 비밀번호가 일치하지 않습니다");
						//필드를 초기화한다
						txtLgnID.Text = "";
						txtLgnPW.Text = "";
						//탭을 아이디칸으로 이동시킨다
						txtLgnID.Focus();
						break;
					case -1:
						MessageBox.Show("DB에서 문제가 발생했습니다");
						break;
					default:
						MessageBox.Show("알 수 없는 에러가 발생했습니다");
						break;
				}
			}
		}

		//Enter키를 입력했을 시 발생하는 메서드
		private void frmLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLgnOK_Click(sender, e);
			}
		}

		private void txtLgnPW_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
		}

		private void frmLogin_Shown(object sender, EventArgs e)
		{
			//탭을 아이디칸으로 이동시킨다
			txtLgnID.Focus();
		}
	}
}
