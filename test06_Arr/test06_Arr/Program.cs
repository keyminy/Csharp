using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test06_Arr
{
	class Program
	{
		static void Main(string[] args)
		{
			Student[] students = new Student[30];
			students[0] = new Student("lee");
			students[1] = new Student("kim");
			students[0].Name = "쿠쿠";
			Console.WriteLine(students[0].Name);
		}
	}
	class Student
	{
		private int kor;
		private string name;

		//생성자
		public Student(string name)
		{
			this.name = name;
		}
		public string Name { get; set; }
	}

}
