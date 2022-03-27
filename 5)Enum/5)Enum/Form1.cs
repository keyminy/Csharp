using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Enum {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		//enum 정의
		private enum enumDay {
			MonDay, //0
			Tuesday, //1
			Wednesday, //2
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
		enum enumTime {
			Morning,
			Afternoon,
			Evening
		}

		private void Form1_Load(object sender, EventArgs e) {
			//form이 로딩될때 실행될 이벤트
			//lobxDay listBox에 enumDay값넣기
			lboxDay.Items.Add(enumDay.MonDay);
			lboxDay.Items.Add(enumDay.Tuesday);
			lboxDay.Items.Add(enumDay.Wednesday);
			lboxDay.Items.Add(enumDay.Thursday);
			lboxDay.Items.Add(enumDay.Friday);
			lboxDay.Items.Add(enumDay.Saturday);
			lboxDay.Items.Add(enumDay.Sunday);

			//lboxTime listBox에 enumTime 넣기
			lboxTime.Items.Add(enumTime.Morning);
			lboxTime.Items.Add(enumTime.Afternoon);
			lboxTime.Items.Add(enumTime.Evening);
		}

		private void btnResult_Click(object sender, EventArgs e) {
			//준호와 Monday(월요일) Afternoon(점심)에 보기로 했습니다.
			string strResult = tboxName.Text + "와 " + lboxDay.SelectedItem.ToString() + "(요일) " + lboxTime.SelectedItem.ToString() + " 에 보기로 했습니다.";
			//lboxDay.SelectedItem = listBox에서 선택된 것 가져오기!!..
			tboxResult.Text = strResult;
		}

		private void btnResult2_Click(object sender, EventArgs e) {
			//string strResult = String.Format($"{tboxName.Text}와 {lboxDay.SelectedItem.ToString()}(요일) {lboxTime.SelectedItem.ToString()}에 보기로 했당");
			string strResult = TextLoad(tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
			tboxResult.Text = strResult;
		}

		/// <summary>
		/// String.Format() 한 문자열을 만들어줌.
		/// </summary>
		/// <param name="strName">이름</param>
		/// <param name="strday">날짜</param>
		/// <param name="strTime">시간</param>
		/// <returns></returns>
		private string TextLoad(string strName,string strday,string strTime) {
			string strText = String.Format($"{strName}와 {strday}(요일) {strTime}에 보기로 했당");
			return strText;
		}
	}
}
