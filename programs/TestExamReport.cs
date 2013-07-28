// programs/TestExamReport.cs

namespace ExamReport
{
using NUnit.Framework;

	[TestFixture]
	public class TestExamReport
	{
		[Test]
		public void TestExam()
		{
			var exam = new Exam();
			Assert.AreEqual("A", exam.ScoreToGrade(90));
			Assert.AreEqual("B", exam.ScoreToGrade(80));
			Assert.AreEqual("C", exam.ScoreToGrade(70));
			Assert.AreEqual("D", exam.ScoreToGrade(60));
			Assert.AreEqual("F", exam.ScoreToGrade(50));

			exam.InputScore("국어", 80);
			exam.InputScore("산수", 60);

			Assert.AreEqual(@"국어 : 80 (B)
산수 : 60 (D)
", exam.Report());

		}
	}
}

