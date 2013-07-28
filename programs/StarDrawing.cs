// programs/StarDrawing.cs

namespace StarDrawing
{
	using System;
	public class Star
	{
		string LF = "\n";
		string STAR = "*";
		string SPACE = " ";

		public string Pad(int size, string ch)
		{
			string pad = "";
			for (int n = 1; n <= size; n++)
			{
				pad += ch;
			}
			return pad;
		}

		public string LeftTriangle(int size)
		{
			string lines = "";
			for (int n = 1; n <= size; n++)
			{
				lines += Pad(n, STAR);
				lines += LF;
			}
			return lines;
		}

		public string RightTriangle(int size)
		{
			string lines = "";
			for (int n = 1; n <= size; n++)
			{
				lines += Pad(size - n, SPACE) + Pad(n, STAR);	
				lines += LF;
			}
			return lines;
		}

		public string Pyramid(int size)
		{
			string lines = "";
			for (int n = 1; n <= size; n++)
			{
				lines += Pad(size - n, SPACE) + Pad(n*2 - 1, STAR);
				lines += LF;
			}
			return lines;
		}
	}
}
