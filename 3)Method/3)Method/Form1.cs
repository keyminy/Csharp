using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Method
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void btnPlus_Click(object sender, EventArgs e)
		{
			int iNumA = int.Parse(tboxNum1.Text);
			int iNumB = int.Parse(tboxNum2.Text);

			//int iResult = iNumA + iNumB;
			//tboxResult.Text = iResult.ToString();

			tboxResult.Text = fPlus(iNumA, iNumB).ToString();
			//다음과 같이 함수를 사용해 2줄을 1줄로 줄임

		}


		private void btnMinus_Click(object sender, EventArgs e)
		{
			int iNumA = int.Parse(tboxNum1.Text);
			int iNumB = int.Parse(tboxNum2.Text);

			//int iResult = iNumA - iNumB;
			//tboxResult.Text = iResult.ToString();

			tboxResult.Text = fMinus(iNumA, iNumB).ToString();
		}

		private void btnMulti_Click(object sender, EventArgs e)
		{
			int iNumA = int.Parse(tboxNum1.Text);
			int iNumB = int.Parse(tboxNum2.Text);

			//int iResult = iNumA * iNumB;
			//tboxResult.Text = iResult.ToString();

			tboxResult.Text = fMulti(iNumA, iNumB).ToString();
		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			int iNumA = int.Parse(tboxNum1.Text);
			int iNumB = int.Parse(tboxNum2.Text);

			//int iResult = iNumA / iNumB;
			//tboxResult.Text = iResult.ToString();

			tboxResult.Text = fDiv(iNumA, iNumB).ToString();
		}

		private int fPlus(int iA,int iB)
		{
			int iResult = iA + iB;
			return iResult;
		}		
		
		private int fMinus(int iA,int iB)
		{
			int iResult = iA - iB;
			return iResult;
		}		
		private int fMulti(int iA,int iB)
		{
			int iResult = iA * iB;
			return iResult;
		}		
		private int fDiv(int iA,int iB)
		{
			int iResult = iA / iB;
			return iResult;
		}

	}
}
