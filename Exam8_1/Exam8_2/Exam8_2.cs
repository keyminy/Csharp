using MyLibrary;
using System;

namespace Exam8_2
{
	public class Exam8_2
	{
		public void Run()
		{
			PrintResult(Util.GetDigit());
		}
		private void PrintResult(int digit)
		{
			//범위 오류 체크
			if (digit < 0 || digit > 100)
			{
				Console.WriteLine("[오류]숫자가 아니거나 또는 범위를 벗어났습니다.");
				return; //프로그램 종료
			}
			if (digit >= 90)
				Console.WriteLine("우수");
			else
			{
				Console.WriteLine("보통");
				Console.WriteLine("좀 더 노력하세요");
			}
		}

	}
}
