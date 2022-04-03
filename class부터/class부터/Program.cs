using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class부터 {
	class Program {
		static void Main(string[] args) {
			Student st = new Student();
			st.Grade = 1;
			st.StudentClass = 10;
			st.StudentId = 35;
			st.Name = "홍길동";
			st.Address = "서울 ";

			Human h = st;
			//C#은 내 ToString()을 쓴다고 명시적으로 선언해줘야한다
			Console.WriteLine(h);
			Console.WriteLine("==========");
			Console.WriteLine(st);
		}
	}
}
