using StudentGrade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void transcript_Click(object sender, EventArgs e)
		{
			string name = name_textBox.Text;
			int chi,math,eng;
			if (!int.TryParse(chinese_textBox.Text, out chi))
			{
				MessageBox.Show("請輸入國文成績!");
				return;
			}
			if(!int.TryParse(math_textBox.Text, out math))
			{
				MessageBox.Show("請輸入數學成績!");
				return;
			}
			if (!int.TryParse(english_textBox.Text, out eng))
			{
				MessageBox.Show("請輸入英文成績!");
				return;
			}
			try
			{
				Student student = new GradeCalculate(name, chi, math, eng);
				transcript.Text = student.GetTranscript();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			

			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
