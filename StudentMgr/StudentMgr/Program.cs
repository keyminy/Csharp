using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kjlee; //나는 kjlee에 있는 네임스페이스에 있는 클래스를 쓸꺼야

namespace StudentMgr
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "쎄터이름 활용";
           // student1.SetAge(1000);
           // student1.SetAge(-1);
            
            Console.WriteLine(student1.Name);
        }
    }
    
}
