using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_String
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//strText 값 : Sample, Test,Text
			string strText = lblText.Text;
			lblContain.Text = strText.Contains("Test").ToString();
			lblEquals.Text = strText.Equals("Test").ToString();
			lblLength.Text = strText.Length.ToString();
			lblReplace.Text = strText.Replace("Test", "I Can").ToString();

			string[] strSplit = strText.Split(',');
			lblSplit1.Text = strSplit[0].ToString();
			lblSplit2.Text = strSplit[1].ToString();
			lblSplit3.Text = strSplit[2].ToString().TrimStart();

			lblSubstring.Text = strText.Substring(3, 5).ToString();
			// 문자열에서 3번째 문자 부터 5개를 반환 합니다. 

			lblTolower.Text = strText.ToLower();
			lblToUpper.Text = strText.ToUpper();
			lblTrim.Text = strText.Trim();
		}

		private void lblText_Click(object sender, EventArgs e)
		{

		}
	}
}
