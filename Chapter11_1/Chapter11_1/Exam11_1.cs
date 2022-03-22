using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_1
{
	class Exam11_1
	{
		public void Run()
		{
			TestStudent();
		}

		private void TestStudent()
		{
			//여기서 test해보자
			Student[] students = new Student[]
				{new Student("홍길동",89,1),new Student("황진이", 87, 2)};
			IEnumerator enumerator = students.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Console.WriteLine(enumerator.Current);
			}
		}

		private void TestBasic()
		{
			int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			//foreach(요소들의 타입 변수 in IEnumerable을 구현하고있는 객체(array))
			foreach (int i in intArray)
				Console.WriteLine(i);
		}
	}


	class Student
	{
		public string Name { get; set; }
		public int Score { get; set; }
		public int Id { get; set; }
		public Student(String name,int score,int id)
		{
			Name = name;
			Score = score;
			Id = id;
		}
		public override string ToString()
		{
			return $"{Name}[{Id}][{Score}]";
		}
	}
}
