using System;

namespace gameOfIntervals
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			double score = 0;
			double first = 0;
			double second = 0;
			double third = 0;
			double forth = 0;
			double fifth = 0;
			double sixth = 0;
			double total = 0;


			for (int i = 1; i <= n; i++)
			{
				double num = double.Parse(Console.ReadLine());

				if (num>=0&&num<=9)
				{
					first++;
					score += num * 20 / 100;
				}
				if (num>=10&&num<=19)
				{
					second++;
					score += num * 30 / 100;
				}
				if (num>=20&&num<=29)
				{
					third++;
					score += num * 40 / 100;
				}
				if (num>=30&&num<=39)
				{
					forth++;
					score += 50;
				}
				if (num>=40&&num<=50)
				{
					fifth++;
					score += 100;
				}
				if (num<0||num>50)
				{
					sixth++;
					score /= 2.0;
				}
				total++;

			}

			Console.WriteLine($"{score:f2}\nFrom 0 to 9: {(first/total*100):f2}%\nFrom 10 to 19: {(second/total*100):f2}%\nFrom 20 to 29: {(third/total*100):f2}%\nFrom 30 to 39: {(forth/total*100):f2}%\nFrom 40 to 50: {(fifth/total*100):f2}%\nInvalid numbers: {(sixth/total*100):f2}%");


		}
	}
}
