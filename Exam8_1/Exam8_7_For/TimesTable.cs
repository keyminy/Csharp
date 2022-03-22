using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_7_For
{
	class TimesTable
	{
		public int Base { get; set; }
		//Base : 몇단을 출력 할 것인지

		//생성자 만들기
		public TimesTable(int ibase)
		{
			Base = ibase;
		}
		public TimesTable():this(2)
		{

		}
		public void PrintBase()
		{
			//변수를 넣을때만 {변수}로 써준다
			//Base는 TimesTable이 만들어지는 순간 생성자에 의해서 2라는 값을 가짐
			for(int i = 1; i <= 9; i++)
			{
				Console.WriteLine($"{Base} * {i} = {Base*i}");
			}
		}
	}
}
