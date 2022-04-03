using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_ConsoleMenu만들기 {
	class MenuItem {
		//public delegate void MenuKeyPressDelegate(object sender, EventArgs args);

		//이벤트핸들러 등록
		public event EventHandler MenuKeyPressEventHandler;
		public string MenuChar { get; set; } //1.
		public string MenuTitle { get; set; } //Menu 1

		public void CallEvent(object sender,string args) {
			if (MenuKeyPressEventHandler != null) {
				MenuKeyPressEventHandler(sender, new MenuKeyPressArgs(args));
			}
		}

		//public MenuKeyPressDelegate KeyPressDelegate { get; set; } 
		//1을 눌렀을때 실행될 함수
		//func(sender,args)를 보냄

		//public MenuItem(string menu_char,string menu_title,MenuKeyPressDelegate dele) {
		//	MenuChar = menu_char;
		//	MenuTitle = menu_title;
		//	KeyPressDelegate = dele;
		//}
		public MenuItem(string menu_char,string menu_title) {
			MenuChar = menu_char;
			MenuTitle = menu_title;
		}
		public MenuItem() :this(null,null){

		}

	}
}
