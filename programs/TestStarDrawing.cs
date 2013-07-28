// programs/TestStarDrawing.cs

namespace StarDrawing
{
	using NUnit.Framework;

	[TestFixture]
	public class TestStarDrawing
	{
		[Test]
		public void TestStar()
		{
			var star = new Star();

			Assert.AreEqual("*****", star.Pad(5, "*"));
			Assert.AreEqual("     ", star.Pad(5, " "));
			
			Assert.AreEqual(@"*
**
***
****
*****
", star.LeftTriangle(5));

			Assert.AreEqual(@"    *
   **
  ***
 ****
*****
", star.RightTriangle(5));

			Assert.AreEqual(@"  *
 ***
*****
", star.Pyramid(3));

		}
	}
}
