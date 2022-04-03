using class부터;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event {
	class Exam17_1 {
		delegate void MyDelegate(int val);

		public void Run() {
			Student st = new Student();
			st.Name = "홍길동";

			MyDelegate dele = new MyDelegate(DelegateTest);
			dele(4);
		}

		private void DelegateTest(int myVal) {
			Console.WriteLine($"DelegateTest() called {myVal}");
		}
	}
}
