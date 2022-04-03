using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class부터 {
	public class Human : Animal{
		public string Name { get; set; }
		public string Address { get; set; }
		public string CellPhone { get; set; }

		public Human() {
			Console.WriteLine("Human : " + this.ToString());
		}

		//인간만이 할 수 있는 행동 : 그리고, 공부
		public void Drawing() {
			Console.WriteLine("I'm drawing a picture");
		}
		public void Study() {
			Console.WriteLine("I'm studing C#");
		}

		public override void WhoAreYou() {
			//override : 내 껄로 쓰겟다
			System.Console.WriteLine("I'm a Human");
		}

		//Human클래스만의 ToString()을 재정의 하고싶다.
		//앞에 new 키워드를 쓴다!!
		//자식들이 이 Tostring()을 물려받지만 재정의 할 수 없게됨(virtual안썻으니)
		 public override string ToString() {
			return $"저의 주소는 {Address}";
		}

		
	}
}
