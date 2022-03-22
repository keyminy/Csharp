using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public class Util
	{
		/// <summary>
		/// 콘솔로부터 0이상의 숫자를 받아들입니다.
		/// 만일 문자가 입력되면 -1이 반환됩니다.
		/// 숫자가 입력된 경우 int 형식으로 반환 됩니다.
		/// </summary>
		/// <returns>int 숫자</returns>
		static public int GetDigit()
		{
			Console.WriteLine("숫자를 입력하세요[0~100] : ");
			string val = Console.ReadLine();
			return ConvertString2Int(val); //val==-1은 에러
		}
		/// <summary>
		/// <para>콘솔로부터 0이상의 숫자를 받아들입니다.
		/// 만일 문자가 입력되면 -1이 반환됩니다.
		/// 숫자가 입력된 경우 int 형식으로 반환 됩니다.</para>
		/// <para>이 함수는 주어진 min값과 max값의 범위를 체크합니다.
		/// 만일 범위를 벗어나면 -2를 반환합니다.</para>
		/// </summary>
		/// <returns>int 숫자</returns>
		static public int GetDigit(int min,int max)
		{
			Console.WriteLine("숫자를 입력하세요[0~100] : ");
			string val = Console.ReadLine();
			int iret =  ConvertString2Int(val); //val==-1은 에러
			if (iret < 0) return iret; //iret가 음수면 그냥 return으로 보내기
			if (iret > max || iret < min) return -2; //범위 오버
			return iret;
		}
		static public int ConvertString2Int(string str)
		{
			int result = 0;
			bool ret = int.TryParse(str, out result);
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
