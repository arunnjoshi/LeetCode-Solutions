using System;

namespace LeetCode.Problems
{
	public class IsPalindrome
	{
		public static bool Palindrome(int x)
		{
			if (x < 0)
			{
				return false;
			}
			string res = x.ToString();
			string revX = string.Empty;
			int strLen = res.Length;
			for (int i = strLen - 1; i >= 0; i--)
			{
				revX = revX + res[i];
                System.Console.WriteLine(revX);
			}
			return res == revX;

		}
	}
}