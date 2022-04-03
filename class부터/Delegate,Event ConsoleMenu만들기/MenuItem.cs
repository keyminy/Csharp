using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_ConsoleMenu만들기 {
	class MenuItem {
		public delegate void MenuKeyPressDelegate(object sender, MenuArgs args);
		public string MenuChar { get; set; } //1.
		public string MenuTitle { get; set; } //Menu 1
		public MenuKeyPressDelegate KeyPressDelegate { get; set; } //1을 눌렀을때 실행될 함수
																   //func(sender,args)를 보냄

		public MenuItem(string menu_char,string menu_title,MenuKeyPressDelegate dele) {
			MenuChar = menu_char;
			MenuTitle = menu_title;
			KeyPressDelegate = dele;
		}
		public MenuItem() :this(null,null,null){

		}

	}
}
