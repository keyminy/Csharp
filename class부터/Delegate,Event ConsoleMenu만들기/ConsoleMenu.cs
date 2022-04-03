using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_ConsoleMenu만들기 {
	class ConsoleMenu {
		public List<MenuItem> MenuList { get; set; }
		public ConsoleMenu() {
			MenuList = new List<MenuItem>();
		}
		//list 메뉴 보여주기
		public void Show() {
			foreach(MenuItem item in MenuList) {
				Console.WriteLine($"{item.MenuChar}, {item.MenuTitle}");
			}
			Console.WriteLine();
		}
		public void Read() {
			Console.Write("메뉴 선택 : ");
			string returnVal = Console.ReadLine(); //1,2,q 입력됨
			foreach(MenuItem item in MenuList) {
				if(item.MenuChar==returnVal && item.KeyPressDelegate != null) {
					//조건 : MenuChar가 returnVal과 같고 Delegate가 불러져야함
					item.KeyPressDelegate(this, new MenuKeyPressArgs(returnVal));
					//public delegate void MenuKeyPressDelegate(object sender, MenuArgs args);
					//매개변수 => this : 내가 불렀다, 두번째값 : 사용자가 입력한 값
				}
			}
		}
	}
}
