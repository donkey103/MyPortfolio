//기능 구현 후 코드 최적화 예정

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace comment
{
	class DBconnection
	{
		public DBconnection() { }
		private string sqlconn = "Server=localhost;Database=iotdb;Uid=root;Pwd=wjdqhqhdksrhk;";
		private MySqlConnection conn;


		// DB연결 메서드
		public void DBconnect()
		{
			conn = new MySqlConnection(sqlconn);
			conn.Open();
		}
		//DB 종료 메서드
		public void Endconnect()
		{
			if(conn != null)	//커넥션이 연결되어 있으면
			{
				conn.Close();
			}
		}

		public ListView Select(string sql, ListView aList, int n)
		{
			DBconnect();
			try
			{
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();


				while (rdr.Read())
				{
					ListViewItem lvt = new ListViewItem();
					for (int i = 0; i < n; i++)
					{
						lvt.SubItems.Add(rdr.GetString(i));
						//lvt.SubItems.Add(rdr.GetString(0));     // 아이디
						//lvt.SubItems.Add(rdr.GetString(1));     // 비밀번호
						//lvt.SubItems.Add(rdr.GetString(2));     // 이름
						//lvt.SubItems.Add(rdr.GetString(3));     // 나이
						//lvt.SubItems.Add(rdr.GetString(4));     // 결혼유무
						//lvt.SubItems.Add(rdr.GetString(5));     // 비교
					}
					aList.Items.Add(lvt);
				}
				rdr.Close();
				return aList;
			}
			catch
			{
				return null;
			}
			finally
			{
				conn.Close();
			}
		}

		public int Execute(string sql)
		{
			try
			{
				DBconnect();
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				int rtn = cmd.ExecuteNonQuery();
				if (rtn > 0)
					return 1;
				else
					return 0;
			}
			catch
			{
				return -1;
			}
			finally
			{
				Endconnect();
			}
		}

		//아이디와 비밀번호를 확인하는 sql 쿼리
		public int pwdConfirm(string id, string pwd)    //아이디와 비밀번호를 인자로 받는다
		{
			string sql = "SELECT userid, passwd FROM users ";
			sql += " WHERE userid = '" + id + "' ";
			sql += " AND passwd = '" + pwd + "' ";
			try
			{
				DBconnect();

				MySqlCommand cmd = new MySqlCommand(sql, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				if (rdr.HasRows == true) //값을 찾았으면
				{
					return 1;   // 성공
				}
				else
				{
					return 0;   // 실패
				}
			}
			catch
			{
				return -1;      //DB에러 발생
			}
			finally
			{
				Endconnect();
			}
		}// pwdConfirm()의 끝

		// tableNumber에 해당하는 테이블에서 id에 해당하는 데이터를 삭제한다
		private string[] table = { "users", "comment" };    //각 번호에 해당하는 테이블의 이름
		private string[] idstring = { "userid", "id" };		// 각 테이블에 해당하는 PK 아이디

		public int DeleteQuery(int tableNumber, string id)
		{
			string sql = " DELETE FROM " + table[tableNumber] + " ";
			sql += " WHERE " + idstring[tableNumber] + " = '" + id + "'";
			Console.WriteLine("DB: " +sql);
			try
			{
				DBconnect();
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				int rtn = cmd.ExecuteNonQuery();
				return rtn;
			}
			catch
			{
				return -1;
			}
			finally
			{
				Endconnect();
			}
		}

	}
}
