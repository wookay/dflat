// programs/Hangul.cs

namespace HangulSystem
{
	using System;
	using System.Collections.Generic;

	public class Hangul
	{
		int GA = 0xac00;
		// int HIH = 0xd7a4;

		string[] 초성 = new string[] { "ㄱ", "ㄲ", "ㄴ", "ㄷ", "ㄸ", "ㄹ", "ㅁ", "ㅂ", "ㅃ", "ㅅ", "ㅆ", "ㅇ", "ㅈ", "ㅉ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ" };
		string[] 중성 = new string[] { "ㅏ", "ㅐ", "ㅑ", "ㅒ", "ㅓ", "ㅔ", "ㅕ", "ㅖ", "ㅗ", "ㅘ", "ㅙ", "ㅚ", "ㅛ", "ㅜ", "ㅝ", "ㅞ", "ㅟ", "ㅠ", "ㅡ", "ㅢ", "ㅣ" };
		string[] 종성 = new string[] { string.Empty, "ㄱ", "ㄲ", "ㄳ", "ㄴ", "ㄵ", "ㄶ", "ㄷ", "ㄹ", "ㄺ", "ㄻ", "ㄼ", "ㄽ", "ㄾ", "ㄿ", "ㅀ", "ㅁ", "ㅂ", "ㅄ", "ㅅ", "ㅆ", "ㅇ", "ㅈ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ" };

		public string[] Separate(string ch)
		{
			return SeparateChar(Convert.ToChar(ch));
		}

		public string[] SeparateChar(char ch)
		{
			int code = Convert.ToInt32(ch);
			int n = code - GA;
			int 초성값 = n / (21 * 28);
			n = n % (21 * 28);
			int 중성값 = n / 28;
			int 종성값 = n % 28;
			List<string> sep = new List<string>();
			sep.Add(초성[초성값]);
			sep.Add(중성[중성값]);
			sep.Add(종성[종성값]);
			return new string[] { 초성[초성값], 중성[중성값], 종성[종성값] };
		}

		public string Compose(string[] sep)
		{
			int 초성값 = Array.IndexOf(초성, sep[0]);
			int 중성값 = Array.IndexOf(중성, sep[1]);
			int 종성값 = Array.IndexOf(종성, sep[2]);
            int code = GA + (초성값 * 21 + 중성값) * 28 + 종성값;
            return Convert.ToChar(code).ToString();
		}

		public string Chosungs(string text)
		{
			List<string> list = new List<string>();
			foreach (char ch in text)
			{
				string[] sep = SeparateChar(ch);				
				list.Add(sep[0]);	
			}
			return string.Join(string.Empty, list.ToArray());
		}
    }
}
