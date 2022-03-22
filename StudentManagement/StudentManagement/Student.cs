﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
	public class Student
	{
		//필드,프로퍼티
		public Grade StGrade  { get; set; } //PK
		public StudentClass StClass { get; set; } //PK
		public int StNumber { get; set; } //PK,학생 고유번호(학번)
		public string Name { get; set; } //Not Null
		public Sex StSex { get; set; } // Enum Sex참고

		//생성자
		public Student(Grade grade, StudentClass stclass, int stnumber, string name, Sex sex)
		{
			this.StGrade = grade;
			this.StClass = stclass;
			this.StNumber = stnumber;
			this.Name = name;
		}
		public Student(Grade grade,StudentClass stclass, int stnumber,string name)
			:this(grade,stclass,stnumber,name,Sex.미확인)
		{
	
		}

		//메서드
		public void PrintMe()
		{
			Console.WriteLine(StGrade + " : " + StClass + " : " + StNumber + " [ " + Name + " ] ");
		}
	}
}
