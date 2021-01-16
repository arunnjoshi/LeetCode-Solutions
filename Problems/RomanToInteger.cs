using System.Collections.Generic;

namespace LeetCode.Problems
{
	public class RomanToInteger
	{
		public static int RomanToInt(string s)
		{
			Dictionary<string, int> RomanNumbers = new Dictionary<string, int>
			{
				{"I",1},
				{"V",5},
				{ "X",10},
				{"L",50},
				{"C",100},
				{"D",500},
				{"M",1000}
			};

			int res = 0;
			for (int i = 0; i < s.Length; i++)
			{
				string roman = s[i].ToString();
				if (i < s.Length - 1 && RomanNumbers[roman] < RomanNumbers[s[i + 1].ToString()])
				{
					res -= RomanNumbers[roman];
				}
				else
					res += RomanNumbers[roman];
			}
			return res;

		}
	}
}