using System;

namespace sumOfTwoNum
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			int secNum = int.Parse(Console.ReadLine());
			int magic = int.Parse(Console.ReadLine());

			int counter = 0;
			int sum = 0;
			int combination = 0;

			for (int i = firstNum; i <= secNum; i++)
			{
				for (int j = firstNum; j <= secNum; j++) 
				{
					counter++;
					sum = i + j;

					if ((i+j)==magic)
					{
						Console.WriteLine($"Combination N:{counter} ({i} + {j} = {sum})");
						combination++;
					}

				}
				if (combination>0)
				{
					break;
				}
			}

			if (combination==0)
			{
				Console.WriteLine($"{counter} combinations - neither equals {magic}");
			}

		}
	}
}
