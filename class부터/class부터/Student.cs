using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class부터 {
	public class Student : Human{
		//Human은 Animal을 상속했으므로 자도으로 Animal까지 상속되어있음
		public int Grade { get; set; }
		public int StudentClass { get; set; }
		public int StudentId { get; set; }
		//Student만의 메서드.
		public void 시험을보다() {
			Console.WriteLine("저는 시험을 보고 있습니다.");
		}
		public override void WhoAreYou() {
			//override : 내 껄로 쓰겟다
			System.Console.WriteLine("I'm a Student");
		}
		public override string ToString() {
			return $" {base.ToString()} [저는 ] {Grade} 학년 {StudentClass}반 {StudentId}번인 {Name}입니다.";
		}
	}
}
