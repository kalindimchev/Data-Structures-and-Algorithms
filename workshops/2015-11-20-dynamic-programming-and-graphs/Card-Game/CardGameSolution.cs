namespace Cards
{
	using System;
	using System.Linq;

	public class StartUp
	{
		static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var numbers = Console.ReadLine().Split(' ').Select(int.Parse);

			var maxpoints = new int[n, n];

			for(var i = 0; i < n - 2; i++)
			{
				maxpoints[i, i + 2] = numbers[i + 1] * (numbers[i] + numbers[i + 2]);
			}
			
			// dp

			Console.WriteLine(maxpoints[0, n - 1]);
		}
	}
}
