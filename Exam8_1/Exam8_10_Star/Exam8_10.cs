using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_10_Star
{
	class Exam8_10
	{
		public void Run()
		{
			for(int i = 0; i < 5; i++)
			{
				//공백 만들기
				for(int k = 0; k < 4 - i; k++)
				{
					Console.Write(" ");
				}
				//별만들기
				for(int j = 0; j < 2*i+1; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
