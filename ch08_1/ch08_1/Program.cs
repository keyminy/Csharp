using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch08_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int min = 0;
			int max = 5;

			Console.WriteLine("숫자 입력 : ");
			string val = Console.ReadLine();
			
			int c = int.Parse(val); //숫자가 들어가짐
			Console.WriteLine("c의 값은 : " + c);

			switch (c)
			{//c라는 int값 value를 괄호 안에 주었다.
			//case : else if : c값이 이거라면~~
				case 0:
					//c가 0이라면?
					Console.WriteLine("0이 입력되었습니다.");
					break;
				case 1:
					Console.WriteLine("1이 입력되었습니다.");
					break;
				case 2:
					Console.WriteLine("2이 입력되었습니다.");
					break;
				default:
					//if절의 else문과 같다.
					Console.WriteLine("해당사항 없습니다.");
					break;
			}
		}
	}
}
