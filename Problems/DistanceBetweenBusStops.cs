using System;

namespace LeetCode.Problems
{
	public class DistanceBetweenBusStops
	{
		public static int Solutions(int[] distance, int start, int destination)
		{
			// start to  destination
			int clockSum = GetDistance(distance, start, destination);
			// destination to  start
			int antiCLockSum = GetDistance(distance, destination, start);
			return Math.Min(clockSum, antiCLockSum);
		}

		private static int GetDistance(int[] distance, int start, int destination)
		{
			int sum = 0;
			int size = distance.Length;
			while (start != destination)
			{
				sum += distance[start];
				start = (start == size - 1) ? 0 : start + 1;
				if (start == destination)
					return sum;
			}
			return sum;
		}

	}
}
