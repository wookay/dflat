// programs/ExamReport.cs

namespace ExamReport
{
	using System;
	using System.Collections.Generic;

	public class Exam
	{
		string LF = "\n";

		public string ScoreToGrade(int score)
		{
 			if (score >= 90) {
 				return "A";
			} else if (score >= 80) {
 				return "B";
			} else if (score >= 70) {
 				return "C";
			} else if (score >= 60) {
 				return "D";
			} else {
 				return "F";
			}
		}

		Dictionary<string, int> info = new Dictionary<string, int>();
		public void InputScore(string subject, int score)
		{
			info.Add(subject, score);
		}

		public string Report()
		{
			string lines = "";
			foreach (KeyValuePair<string, int> pair in info)
			{
				int score = pair.Value;
				lines += String.Format("{0} : {1} ({2})", pair.Key, score, ScoreToGrade(score));
				lines += LF;
			}
			return lines;
		}
	}
}
