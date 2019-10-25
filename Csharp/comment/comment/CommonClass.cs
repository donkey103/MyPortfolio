using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comment
{
	class CommonClass	//일반적인 반복작업을 처리하기 위한 클래스
	{
		// 메인폼의 데이터가 변경되었는지 체크하는 플래그
		// true이면 조회를 실행하고 false로 바뀐다
		public static bool form1_datachanged = false;
		public static bool form2_datachanged = false;


		public struct Number_of_Table	//테이블명을 은닉하기 위한 별도의 테이블 구분
		{
			public const int USER_TABLE = 0;
			public const int COMMENT_TABLE = 1;
		}

		// 쿼리 처리결과를 출력하는 메서드
		public static void rtnValue(int rtn)
		{
			switch (rtn)
			{
				case 1:
					MessageBox.Show("정상적으로 처리되었습니다");
					break;
				case 0:     // 삭제된 열이 없을때
					MessageBox.Show("값을 찾을 수 없습니다");
					break;
				case -1:    // 예외발생 상황
					MessageBox.Show("DB에러 발생");
					break;
				default:
					MessageBox.Show("알 수 없는 에러 발생");
					break;
			}

		}
	}

}
