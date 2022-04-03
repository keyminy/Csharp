﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Event_ConsoleMenu만들기 {
	class Exam17_2 {
		ConsoleMenu Menu;
		public Exam17_2() {
			Menu = new ConsoleMenu();
		}
		public void Run() {
			//1.Menu1 : "1","Menu1",Delegate
			//2.Menu2
			//.....
			//q.종료

			//사용자 입력 : 1엔터치면 ,
			//Menu1의 Delegate가 불러진다.
			CreateMenu();
			while (true) {
				Menu.Show();
				Menu.Read();
			}
		}

		public void CreateMenu() {
			MenuItem item = new MenuItem("1","Menu_Title_1");
			//callback 등록하기
			item.MenuKeyPressEventHandler += Menu_1_Callback;
			Menu.MenuList.Add(item);

			item = new MenuItem("2", "Menu_Title_2");
			item.MenuKeyPressEventHandler += Menu_2_Callback;
			Menu.MenuList.Add(item);

			item = new MenuItem("q", "프로그램 종료");
			Menu.MenuList.Add(item);
			item.MenuKeyPressEventHandler += Quit_Callback;
		}

		private void Quit_Callback(object sender, EventArgs args) {
			Console.WriteLine($"Quit_Callback() 호출됨 sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
			Console.WriteLine("bye....");
			Environment.Exit(0);
		}

		private void Menu_1_Callback(object sender, EventArgs args) {
			Console.WriteLine($"Menu_1_Callback() 호출됨 sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
		}
		private void Menu_2_Callback(object sender, EventArgs args) {
			Console.WriteLine($"Menu_2_Callback() 호출됨 sender={sender.ToString()} args = {((MenuKeyPressArgs)args).MenuChar}");
		}


	}
}
