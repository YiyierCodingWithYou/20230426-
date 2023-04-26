namespace StudentGradeUI
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.GetTranscript = new System.Windows.Forms.Button();
			this.Name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.english = new System.Windows.Forms.Label();
			this.math = new System.Windows.Forms.Label();
			this.transcript = new System.Windows.Forms.TextBox();
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.chinese_textBox = new System.Windows.Forms.TextBox();
			this.english_textBox = new System.Windows.Forms.TextBox();
			this.math_textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// GetTranscript
			// 
			this.GetTranscript.Location = new System.Drawing.Point(208, 365);
			this.GetTranscript.Name = "GetTranscript";
			this.GetTranscript.Size = new System.Drawing.Size(75, 22);
			this.GetTranscript.TabIndex = 0;
			this.GetTranscript.Text = "我被當ㄌㄇ";
			this.GetTranscript.UseVisualStyleBackColor = true;
			this.GetTranscript.Click += new System.EventHandler(this.transcript_Click);
			// 
			// Name
			// 
			this.Name.AutoSize = true;
			this.Name.Location = new System.Drawing.Point(23, 22);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(29, 12);
			this.Name.TabIndex = 1;
			this.Name.Text = "姓名";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "國文";
			// 
			// english
			// 
			this.english.AutoSize = true;
			this.english.Location = new System.Drawing.Point(23, 121);
			this.english.Name = "english";
			this.english.Size = new System.Drawing.Size(29, 12);
			this.english.TabIndex = 3;
			this.english.Text = "英文";
			// 
			// math
			// 
			this.math.AutoSize = true;
			this.math.Location = new System.Drawing.Point(23, 88);
			this.math.Name = "math";
			this.math.Size = new System.Drawing.Size(29, 12);
			this.math.TabIndex = 4;
			this.math.Text = "數學";
			// 
			// transcript
			// 
			this.transcript.ForeColor = System.Drawing.Color.White;
			this.transcript.Location = new System.Drawing.Point(25, 159);
			this.transcript.Multiline = true;
			this.transcript.Name = "transcript";
			this.transcript.ReadOnly = true;
			this.transcript.Size = new System.Drawing.Size(258, 199);
			this.transcript.TabIndex = 5;
			// 
			// name_textBox
			// 
			this.name_textBox.Location = new System.Drawing.Point(58, 19);
			this.name_textBox.MaxLength = 8;
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(100, 22);
			this.name_textBox.TabIndex = 6;
			// 
			// chinese_textBox
			// 
			this.chinese_textBox.Location = new System.Drawing.Point(58, 52);
			this.chinese_textBox.MaxLength = 3;
			this.chinese_textBox.Name = "chinese_textBox";
			this.chinese_textBox.Size = new System.Drawing.Size(100, 22);
			this.chinese_textBox.TabIndex = 7;
			// 
			// english_textBox
			// 
			this.english_textBox.Location = new System.Drawing.Point(58, 118);
			this.english_textBox.MaxLength = 3;
			this.english_textBox.Name = "english_textBox";
			this.english_textBox.Size = new System.Drawing.Size(100, 22);
			this.english_textBox.TabIndex = 8;
			// 
			// math_textBox
			// 
			this.math_textBox.Location = new System.Drawing.Point(58, 85);
			this.math_textBox.MaxLength = 3;
			this.math_textBox.Name = "math_textBox";
			this.math_textBox.Size = new System.Drawing.Size(100, 22);
			this.math_textBox.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 398);
			this.Controls.Add(this.math_textBox);
			this.Controls.Add(this.english_textBox);
			this.Controls.Add(this.chinese_textBox);
			this.Controls.Add(this.name_textBox);
			this.Controls.Add(this.transcript);
			this.Controls.Add(this.math);
			this.Controls.Add(this.english);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Name);
			this.Controls.Add(this.GetTranscript);
			this.Text = "成績單";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GetTranscript;
		private System.Windows.Forms.Label Name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label english;
		private System.Windows.Forms.Label math;
		private System.Windows.Forms.TextBox transcript;
		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.TextBox chinese_textBox;
		private System.Windows.Forms.TextBox english_textBox;
		private System.Windows.Forms.TextBox math_textBox;
	}
}

