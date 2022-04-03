using MyLibrary;

namespace class부터 {
	public class Animal {
		public int Age { get; set; }
		public SexEnum Sex { get; set; }
		public int Weight { get; set; }

		//생성자
		public Animal() {
			System.Console.WriteLine("Animal " + this.ToString());
		}

		public void Sleep() {
			System.Console.WriteLine("I'm slepping now");
		}

		public void Eat() {
			System.Console.WriteLine("I'm eating banana");
		}

		public void Walk() {
			System.Console.WriteLine("I'm working in the street");
		}

		virtual public void WhoAreYou() {
			System.Console.WriteLine("I'm an Animal");
		}
	}
}
