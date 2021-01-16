using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
	public class LongestSubstring
	{
		public static int LengthOfLongestSubstring(string s)
		{
			int size = s.Length;
			int ans = 0;
			int i = 0;
			if (size == 0 || size == 1)
			{
				return size;
			}

			Dictionary<char, int> map = new Dictionary<char, int>();
			for (int j = 0; j < size; j++)
			{
				if (map.ContainsKey(s[j]))
				{
					int mapVal = map[s[j]];
					i = (mapVal > i) ? mapVal : i;
				}
				ans = (ans > j - i + 1) ? ans : j - i + 1;
				map[s[j]] = j + 1;
			}

			return ans;
		}
	}
}