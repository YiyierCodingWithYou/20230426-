using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
	public class Program
	{   //設計一個學生類別、輸入姓名、各科成績，能顯示總分和平均分數，最高最低是哪一科，分數是多少
		static void Main(string[] args)
		{
			Student one = new Student("泰泰", 50, 80, 70);
			Console.WriteLine(one.GetTranscript());

			Student two = new GradeCalculate("依依", 50, 70, 45);
			Console.WriteLine(two.GetTranscript());
		}
	}
	public class Student
	{
		public string Name { get; set; }
		public int ChineseGrade { get; private set; }
		public int MathGrade { get; private set; }
		public int EnglishGrade { get; private set; }

		public Student(string name, int chinese, int math, int english)
		{
			Name = name;
			if (string.IsNullOrEmpty(name))
			{ throw new ArgumentNullException("姓名不得為空"); }
			ChineseGrade = chinese;
			if (chinese < 0 || chinese > 100)
			{ throw new ArgumentException("輸入錯誤，請再次確認國文成績"); }
			MathGrade = math;
			if (math < 0 || math > 100)
			{ throw new ArgumentException("輸入錯誤，請再次確認數學成績"); }
			EnglishGrade = english;
			if (english < 0 || english > 100)
			{ throw new ArgumentException("輸入錯誤，請再次確認英文成績"); }
		}
		public virtual string GetTranscript()
		{
			return $"{Name} 同學您好\n您的本次段考成績如下：\n國文：{ChineseGrade}\t英文：{EnglishGrade}\t數學：{MathGrade}\n";
		}
	}
	public class GradeCalculate : Student

	{
		private int TotalGrade { get; set; }
		private double AverageGrade { get; set; }
		private string HighestScoreSubject { get; set; }
		private string LowestScoreSubject { get; set; }
		public string PassOrNot { get; set; }
		public GradeCalculate(string name, int chinese, int math, int english) : base(name, chinese, math, english)
		{
			TotalGrade = GetTotalGrade();
			AverageGrade = GetAverageGrade();
			HighestScoreSubject = GetHighestGrade();
			LowestScoreSubject = GetLowestGrade();
			PassOrNot = GetPassOrNot();
		}
		public override string GetTranscript()
		{
			return $"{Name} 同學您好\n本次段考成績如下：\r\n\r\n國文：{ChineseGrade}\t數學：{MathGrade}\t英文：{EnglishGrade}\r\n\r\n總分：{TotalGrade}\t總平均：{AverageGrade}" + $"\r\n\r\n最高分科目：{HighestScoreSubject}\r\n最低分科目：{LowestScoreSubject}\r\n\r\n{PassOrNot}";
		}
		private string GetHighestGrade()

		{
			string[] subjects = { "國文", "數學", "英文" };
			int[] grades = { ChineseGrade, MathGrade, EnglishGrade };
			int highestGradeIndex = 0;
			for (int i = 1; i < grades.Length; i++)
			{
				if (grades[i] > grades[highestGradeIndex])
				{
					highestGradeIndex = i;
				}
			}
			string highestSubject = subjects[highestGradeIndex];
			int highestGrade = grades[highestGradeIndex];
			return $"{highestSubject} {highestGrade} 分";
		}
		private string GetLowestGrade()
		{
			string[] subjects = { "國文", "數學", "英文" };
			int[] grades = { ChineseGrade, MathGrade, EnglishGrade };
			int lowestGradeIndex = 0;
			for (int i = 1; i < grades.Length; i++)
			{
				if (grades[i] < grades[lowestGradeIndex])
				{
					lowestGradeIndex = i;
				}
			}
			string lowestSubject = subjects[lowestGradeIndex];
			int lowestGrade = grades[lowestGradeIndex];
			return $"{lowestSubject} {lowestGrade} 分";
		}
		private int GetTotalGrade()
		{
			return ChineseGrade + EnglishGrade + MathGrade;
		}
		private double GetAverageGrade()
		{
			return (GetTotalGrade() / 3.0);
		}
		private string GetPassOrNot()
		{
			string result = "";
			if (GetAverageGrade() < 60)
			{
				result = "A 恭喜你被當ㄌ";
			}
			else
			{
				result = "泥很棒棒ㄛ";
			}
			return result;
		}
	}
}
