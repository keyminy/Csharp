
namespace _3_Method
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
			this.tboxResult = new System.Windows.Forms.TextBox();
			this.tboxNum1 = new System.Windows.Forms.TextBox();
			this.tboxNum2 = new System.Windows.Forms.TextBox();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnMulti = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tboxResult
			// 
			this.tboxResult.Enabled = false;
			this.tboxResult.Location = new System.Drawing.Point(34, 34);
			this.tboxResult.Name = "tboxResult";
			this.tboxResult.Size = new System.Drawing.Size(368, 25);
			this.tboxResult.TabIndex = 0;
			this.tboxResult.Text = "0";
			// 
			// tboxNum1
			// 
			this.tboxNum1.Location = new System.Drawing.Point(34, 79);
			this.tboxNum1.Name = "tboxNum1";
			this.tboxNum1.Size = new System.Drawing.Size(167, 25);
			this.tboxNum1.TabIndex = 1;
			this.tboxNum1.Text = "0";
			// 
			// tboxNum2
			// 
			this.tboxNum2.Location = new System.Drawing.Point(221, 79);
			this.tboxNum2.Name = "tboxNum2";
			this.tboxNum2.Size = new System.Drawing.Size(181, 25);
			this.tboxNum2.TabIndex = 2;
			this.tboxNum2.Text = "0";
			// 
			// btnPlus
			// 
			this.btnPlus.Location = new System.Drawing.Point(34, 124);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnPlus.Size = new System.Drawing.Size(75, 64);
			this.btnPlus.TabIndex = 3;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Location = new System.Drawing.Point(126, 124);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(75, 64);
			this.btnMinus.TabIndex = 4;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnMulti
			// 
			this.btnMulti.Location = new System.Drawing.Point(221, 124);
			this.btnMulti.Name = "btnMulti";
			this.btnMulti.Size = new System.Drawing.Size(75, 64);
			this.btnMulti.TabIndex = 5;
			this.btnMulti.Text = "*";
			this.btnMulti.UseVisualStyleBackColor = true;
			this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
			// 
			// btnDiv
			// 
			this.btnDiv.Location = new System.Drawing.Point(327, 124);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(75, 64);
			this.btnDiv.TabIndex = 6;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnMulti);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.tboxNum2);
			this.Controls.Add(this.tboxNum1);
			this.Controls.Add(this.tboxResult);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tboxResult;
		private System.Windows.Forms.TextBox tboxNum1;
		private System.Windows.Forms.TextBox tboxNum2;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnMulti;
		private System.Windows.Forms.Button btnDiv;
	}
}

