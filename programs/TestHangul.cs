// programs/TestHangul.cs

namespace HangulSystem
{
	using NUnit.Framework;
	using System;
	using System.Collections.Generic;

	[TestFixture]
	public class TestHangul
	{
		[Test]
		public void TestHangulProcessing()
		{
			return;
			Assert.AreEqual('가', Convert.ToChar(0xac00));

			var hangul = new Hangul();
			Assert.AreEqual(new string[] {"ㅎ","ㅏ","ㄴ"},
				hangul.Separate("한"));
			Assert.AreEqual(new string[] {"ㄷ","ㅏ",""},
				hangul.Separate("다"));
			Assert.AreEqual("한", hangul.Compose(new string[] {"ㅎ","ㅏ","ㄴ"}));
			Assert.AreEqual("다", hangul.Compose(new string[] {"ㄷ","ㅏ",""}));
			Assert.AreEqual("ㅈㅁㄷ", hangul.Chosungs("재밌다"));
		}
	}
}
