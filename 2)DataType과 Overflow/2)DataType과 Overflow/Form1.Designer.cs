
namespace _2_DataType과_Overflow
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.tboxNumber = new System.Windows.Forms.TextBox();
			this.btnEx = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblException = new System.Windows.Forms.Label();
			this.lblDouble = new System.Windows.Forms.Label();
			this.lblInt = new System.Windows.Forms.Label();
			this.lblShort = new System.Windows.Forms.Label();
			this.btnShort = new System.Windows.Forms.Button();
			this.btnInt = new System.Windows.Forms.Button();
			this.btnDouble = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tboxNumber
			// 
			this.tboxNumber.Location = new System.Drawing.Point(12, 50);
			this.tboxNumber.Name = "tboxNumber";
			this.tboxNumber.Size = new System.Drawing.Size(614, 25);
			this.tboxNumber.TabIndex = 0;
			// 
			// btnEx
			// 
			this.btnEx.Location = new System.Drawing.Point(650, 50);
			this.btnEx.Name = "btnEx";
			this.btnEx.Size = new System.Drawing.Size(138, 25);
			this.btnEx.TabIndex = 1;
			this.btnEx.Text = "알아서 변환";
			this.btnEx.UseVisualStyleBackColor = true;
			this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Short";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "int";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Double";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 269);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Exception";
			// 
			// lblException
			// 
			this.lblException.AutoSize = true;
			this.lblException.Location = new System.Drawing.Point(145, 269);
			this.lblException.Name = "lblException";
			this.lblException.Size = new System.Drawing.Size(15, 15);
			this.lblException.TabIndex = 6;
			this.lblException.Text = "-";
			// 
			// lblDouble
			// 
			this.lblDouble.AutoSize = true;
			this.lblDouble.Location = new System.Drawing.Point(145, 218);
			this.lblDouble.Name = "lblDouble";
			this.lblDouble.Size = new System.Drawing.Size(15, 15);
			this.lblDouble.TabIndex = 7;
			this.lblDouble.Text = "0";
			// 
			// lblInt
			// 
			this.lblInt.AutoSize = true;
			this.lblInt.Location = new System.Drawing.Point(145, 166);
			this.lblInt.Name = "lblInt";
			this.lblInt.Size = new System.Drawing.Size(15, 15);
			this.lblInt.TabIndex = 8;
			this.lblInt.Text = "0";
			// 
			// lblShort
			// 
			this.lblShort.AutoSize = true;
			this.lblShort.Location = new System.Drawing.Point(145, 115);
			this.lblShort.Name = "lblShort";
			this.lblShort.Size = new System.Drawing.Size(15, 15);
			this.lblShort.TabIndex = 9;
			this.lblShort.Text = "0";
			// 
			// btnShort
			// 
			this.btnShort.Location = new System.Drawing.Point(260, 105);
			this.btnShort.Name = "btnShort";
			this.btnShort.Size = new System.Drawing.Size(138, 25);
			this.btnShort.TabIndex = 10;
			this.btnShort.Text = "Short 변환";
			this.btnShort.UseVisualStyleBackColor = true;
			this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
			// 
			// btnInt
			// 
			this.btnInt.Location = new System.Drawing.Point(260, 161);
			this.btnInt.Name = "btnInt";
			this.btnInt.Size = new System.Drawing.Size(138, 25);
			this.btnInt.TabIndex = 11;
			this.btnInt.Text = "int 변환";
			this.btnInt.UseVisualStyleBackColor = true;
			this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
			// 
			// btnDouble
			// 
			this.btnDouble.Location = new System.Drawing.Point(260, 218);
			this.btnDouble.Name = "btnDouble";
			this.btnDouble.Size = new System.Drawing.Size(138, 25);
			this.btnDouble.TabIndex = 12;
			this.btnDouble.Text = "Double 변환";
			this.btnDouble.UseVisualStyleBackColor = true;
			this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDouble);
			this.Controls.Add(this.btnInt);
			this.Controls.Add(this.btnShort);
			this.Controls.Add(this.lblShort);
			this.Controls.Add(this.lblInt);
			this.Controls.Add(this.lblDouble);
			this.Controls.Add(this.lblException);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEx);
			this.Controls.Add(this.tboxNumber);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tboxNumber;
		private System.Windows.Forms.Button btnEx;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblException;
		private System.Windows.Forms.Label lblDouble;
		private System.Windows.Forms.Label lblInt;
		private System.Windows.Forms.Label lblShort;
		private System.Windows.Forms.Button btnShort;
		private System.Windows.Forms.Button btnInt;
		private System.Windows.Forms.Button btnDouble;
	}
}

