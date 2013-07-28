// programs/MultiTable.cs

namespace MultiTable
{
	using System;
	public class Multi
	{
		string LF = "\n";
		string TAB = "\t";

        public string Formula(int a, int b)
        {
            return String.Format("{0} * {1} = {2}", a, b, a*b);
        }

        public string Cell(int a)
        {
			string lines = "";
			for (int b = 1; b <= 9; b++)
			{
            	lines += Formula(a, b);
				lines += LF;
			}
			return lines;
        }

        public string Table(int from, int to)
        {
			string lines = "";
			for (int b = 1; b <= 9; b++)
			{
				for (int n = from; n <= to; n++)
				{
                	lines += Formula(n, b);
					if (n < to) {
						lines += TAB;
					}
				}
				lines += LF;
			}
			return lines;
        }

        public string FullTable()
		{
			string lines = "";
			lines += Table(2, 5);
			lines += LF;
			lines += Table(6, 9);
			// Console.WriteLine(lines);
			return lines;
		}
    }
}
