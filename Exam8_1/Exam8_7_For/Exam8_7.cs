using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_7_For
{
	class Exam8_7
	{
		internal void Run()
		{
			TimesTable tt = new TimesTable();
			for(int i = 2; i <= 9; i++)
			{
				tt.Base = i; // 오홍..
				tt.PrintBase();
				Console.WriteLine("==========단 바뀜===========");
			}
		}
	}
}
