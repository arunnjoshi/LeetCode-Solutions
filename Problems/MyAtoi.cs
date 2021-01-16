using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
	public class MyAtoi
	{
		static readonly Dictionary<char, bool> dic = new Dictionary<char, bool>
		{
				{'-',true},
				{'+',true},
				{'1',true},
				{'2',true},
				{'3',true},
				{'4',true},
				{'5',true},
				{'6',true},
				{'7',true},
				{'8',true},
				{'9',true},
				{'0',true},
	  	};
		public static int MyAto(string s)
		{
			string res = "";
			s = s.Trim();
			if (s.Length == 0)
			{
				return 0;
			}
			foreach (var ele in s)
			{
				if (dic.ContainsKey(ele) && dic[ele])
				{
					res = res + ele;
				}
				else
					break;
			}
			int ret = 0;
			long ret2 = 0;
			if (!Int32.TryParse(res, out ret))
			{
				if (Int64.TryParse(res, out ret2))
				{
					return ret2 > 0 ? Int32.MaxValue : Int32.MinValue;
				}
				return 0;
			}
			return ret;

		}
	}
}