using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_ConsoleMenu만들기 {
	//상속받은 MenuArgs 쓰지말고 EventArgs를 쓰자
	//class MenuArgs {
	//}
	class MenuKeyPressArgs : EventArgs {
		//우리가 메뉴를 선택했을때, parameter로 전달될 형식을 모델링하는 클래스
		public string MenuChar { get; set; }
		public MenuKeyPressArgs(string menu_char) {
			MenuChar = menu_char;
		}
	}
}
