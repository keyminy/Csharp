using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_1
{
	public class ifTestMgr
	{
		public void Run()
		{
			//여기부터 프로그램 시작
			//첫번째 숫자를 받아들인다.
			int digit = GetDigit();
			PrintResult(digit);

			//깔끔하게 할려면
			//PrintResult(GetDigit());
		}

		private void PrintResult(int digit)
		{
			//범위 오류 체크
			if(digit<0 || digit > 100)
			{
				Console.WriteLine("[오류]숫자가 아니거나 또는 범위를 벗어났습니다.");
				return; //프로그램 종료
			}
			if(digit>90)
				Console.WriteLine("우수");
			else
				Console.WriteLine("잘 모르겟어..");
		}

		private int GetDigit()
		{
			Console.WriteLine("숫자를 입력하세요[0~100] : ");
			string val = Console.ReadLine();
			return  ConvertString2Int(val); //val==-1은 에러
		}
		private int ConvertString2Int(string str)
		{
			int result = 0;
			bool ret = int.TryParse(str, out result); // TryParse의 리턴값이 bool
													  //result변수에다가 매개변수로온 str값을 숫자로 바꾸어 넣어줌
													  //out은 result라는 변수가 위치하고 있는 주소를 의미함.(=주소로 보내줌)
													  //out은 변수 자체를 보내는 것이다.
			if (ret)
			{
				return result;
			}
			else
			{
				return -1; // 점수는 0~100이므로 -1은 에러라는 의미에서 쓰자.
			}
		}
	}
}
