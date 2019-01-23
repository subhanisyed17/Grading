using System;

namespace Grading
{
	class Program
	{
	
		static void Main(string[] args)
		{
			Console.WriteLine("please enter your marks to get your grade");
			int marks = int.Parse(Console.ReadLine());
			try
			{
				string YourGrade = CalculateGrade(marks);
				Console.WriteLine("Your Grade is {0}", YourGrade);
			}
			catch
			{
				Console.WriteLine("An error occured");
			}
			Console.WriteLine("press any key to exit");
			Console.ReadKey(true);
		}// end of main

		private static string CalculateGrade(int marks)
		{
			if (marks >= 95)
				return "A+";
			else if (marks >= 90)
				return "A";
			else if (marks >= 87)
				return "A-";
			else if (marks >= 84)
				return "B+";
			else if (marks >= 80)
				return "B";
			else if (marks >= 77)
				return "B-";
			else if (marks >= 74)
				return "C+";
			else if (marks >= 70)
				return "C";
			else if (marks >= 67)
				return "C-";
			else if (marks >= 63)
				return "D+";
			else if (marks >= 60)
				return "D";
			else
				return "F";
		}
	}
}
