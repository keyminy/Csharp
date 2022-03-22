using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kjlee
{
    //Class의 Fullname은 namespace.class네임이다
    /// <summary>
    /// kjlee.Student 클래스 정의
    /// </summary>
    public class Student
    {
        //private string name; //멤버변수의 기본이 private이구나
        private string address;
        private int age;

        #region 생성자
        public Student() : this(null)
        {
            //this(null)은 자기가 자신의 생성자를 부름
        }
        //메서드 오버로딩 실험
        public Student(String name) : this(name, null)
        {

        }
        public Student(string name, string address)
        {
            this.Name = name;
            this.address = address;
        }

        #endregion

        /// <summary>
        /// getter of name
        /// </summary>
        /// <returns></returns>

        //public string Name //멤버변수인척 하지만 변수가 아니야
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //Name은 변수면서 Property의 역할을 한다.
        public string Name { get; set; }

   
        public int GetAge()
        {
            return age;
        }              

        public void SetAge(int age)
        {
            if(age<0 || age > 121)
            {
                Console.WriteLine("나이는 음수나 120세를 넘을 수 없습니다.");
                return; //밑에 this.age = age 실행안함.
            }
            this.age = age;
        }



    }
}
