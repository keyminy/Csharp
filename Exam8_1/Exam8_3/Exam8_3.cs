using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_3
{
	class Exam8_3
	{
		public void Run()
		{
			//Run()은 사령탑이므로 쫄개들이 하는 일하지마라.
			EvalScore(Util.GetDigit(0, 100));
			//이처럼 프로그램은 사령탑에서 딱 한번의 명령만 하고 
			// 그 밑에서 쫄개들이 일을 바쁘게 하는게 좋다.
		}

		private void EvalScore(int v)
		{
			if (v == -2)
				Console.WriteLine("성적이 범위를 초과하였습니다.");
			else if (v == -1)
				Console.WriteLine("성적에 숫자가 아닌 문자가 있습니다.");
			else if (v > 90)
				Console.WriteLine("A");
			else if (v > 80)
				Console.WriteLine("B");
			else if (v > 70)
				Console.WriteLine("C");
			else if (v > 60)
				Console.WriteLine("D");
			else
				Console.WriteLine("F");
		}	
	}
}
