using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Array {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			ArrayClassTest();
		}

		private void ArrayTest() {
			int[] iArrayTest1 = { 1, 2, 3, 4, 5 };
			
		}

		private void ArrayClassTest() {
			int[] iTest = { 10, 20, 30, 40, 50 };
			int i = iTest.Length; //i=5가 나옴
			Array.Clear(iTest, 2, 2);//2번째 인덱스부터, 2개 지우기
			Array.Resize(ref iTest, 10); //10개짜리 배열로 변경
			int iSearch30 = Array.IndexOf(iTest, 50);//iTest배열에서 50 값 찾기 => 4
 		}

		private void button1_Click(object sender, EventArgs e) {
			int[] iTest = { 10, 5, 30, 4, 15,22,18 };
			lblArrayCount.Text = String.Format($"전체 자료 수 : {iTest.Length.ToString()} 입니다.");

			dgDay["colDay1", 0].Value = iTest[0]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay2", 0].Value = iTest[1]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay3", 0].Value = iTest[2]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay4", 0].Value = iTest[3]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay5", 0].Value = iTest[4]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay6", 0].Value = iTest[5]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay7", 0].Value = iTest[6]; //colDay의 첫 row(0행)에 값 넣기
		}

		private void button2_Click(object sender, EventArgs e) {
			//버튼 여러번 눌릴때, dgDay 초기화 하기
			dgDay.Rows.Clear();
			int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 25, 14, 7, 5, 25 } };
			lblArrayCount.Text = String.Format($"전체 자료 수 : {iTest.Length.ToString()} 입니다.");

			dgDay.Rows.Add(); //행 하나 더 추가하기
			dgDay["colDay1", 0].Value = iTest[0,0]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay2", 0].Value = iTest[0,1]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay3", 0].Value = iTest[0,2]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay4", 0].Value = iTest[0,3]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay5", 0].Value = iTest[0,4]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay6", 0].Value = iTest[0,5]; //colDay의 첫 row(0행)에 값 넣기
			dgDay["colDay7", 0].Value = iTest[0,6]; //colDay의 첫 row(0행)에 값 넣기

			dgDay["colDay1", 1].Value = iTest[1,0]; //colDay의 두번째 row에 값 넣기
			dgDay["colDay2", 1].Value = iTest[1,1]; //colDay의 두번째 row에 값 넣기
			dgDay["colDay3", 1].Value = iTest[1,2]; //colDay의 두번째 row에 값 넣기
			dgDay["colDay4", 1].Value = iTest[1,3]; //colDay의 두번째 row에 값 넣기
			dgDay["colDay5", 1].Value = iTest[1,4]; //colDay의 두번째 row에 값 넣기
			dgDay["colDay6", 1].Value = iTest[1,5]; //colDay의 두번째 row에 값 넣기
			dgDay["colDay7", 1].Value = iTest[1,6]; //colDay의 두번째 row에 값 넣기
		}
	}
}
