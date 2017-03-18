using System;

namespace softUniLogo
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			char dot = '.';
			char diez = '#';
			char wall = '|';
			char klum = '@';

			for (int i = 0; i < 2*n; i++)
			{
				Console.WriteLine(new string(dot, ((12 * n - 5) - 1 - (i * 6)) / 2) + diez + new string(diez, i * 6) + new string(dot,((12 * n - 5) - 1 - (i * 6)) / 2));
			}

			for (int j = 1; j <= n-2; j++)
			{
				Console.WriteLine(wall + new string(dot, 3*j - 1) + new string(diez, (12*n-5)-j*6) + new string(dot, 3*j));
			}

			for (int k = 1; k <= n-1; k++)
			{
				Console.WriteLine(wall + new string(dot, (3*(n-1))-1) + new string(diez, (12*n-5)-6*(n-1))+new string(dot, 3*(n-1)));
			}

			Console.WriteLine(klum + new string(dot, (3 * (n - 1)) - 1) + new string(diez, (12 * n - 5) - 6 * (n - 1)) + new string(dot, 3 * (n - 1)));
		}
	}
}
