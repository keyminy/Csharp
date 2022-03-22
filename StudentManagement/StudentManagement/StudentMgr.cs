using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
	public class StudentMgr
	{
		public struct Student
		{
			public Grade StGrade1 { get; set; } //PK
			public StudentClass StClass1 { get; set; } //PK
			public int StNumber1 { get; set; } //PK,학생 고유번호(학번)
			public string Name1 { get; set; } //Not Null
			public Sex StSex1 { get; set; } // Enum Sex참고
		}
		

		public void Run()
		{
			Student st = RegistStudent();
			PrintMe(st);
			
		}
		public void PrintMe(Student st)
		{
			Console.WriteLine(st.StGrade1 + " : " + st.StClass1 + " : " + st.StNumber1 + " [ " + st.Name1 + " ] ");
		}

		private Student RegistStudent()
		{
			Console.WriteLine("학년 [숫자만 입력] : ");
			string grade = Console.ReadLine();
			//Enter칠떄까지의 값을 다 읽어옴
			Console.WriteLine("반 : ");
			string stclass = Console.ReadLine();
			Console.WriteLine("번호 : ");
			string stnumber = Console.ReadLine();
			Console.WriteLine("이름 : ");
			string stname = Console.ReadLine();

			//Convert(static클래스).ToInt32(stnumber) int로 바꿔줭

			Student st1 = new Student();//구조체 만듬
			st1.StGrade1 = (Grade)Enum.Parse(typeof(Grade), grade);
			return st1;
		}
	}
}
