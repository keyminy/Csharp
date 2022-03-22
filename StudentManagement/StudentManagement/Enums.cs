using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
	public enum Sex
	{
		남성, 여성,	미확인
	}
	public enum Grade
	{
		//Enum안은 이렇게 숫자로 시작할 수 없다..
		//ex.1학년,2학년,3학년 불가
		학년_1 =1,	학년_2=2,	학년_3=3
	}
	public enum StudentClass
	{
		//이런거 만들때 약자쓰지 마세요
		반_1 =1,	반_2=2,	반_3=3,	반_4=4
	}
}
