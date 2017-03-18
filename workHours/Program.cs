using System;

namespace workHours
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int hoursNeeded = int.Parse(Console.ReadLine());
			int employees = int.Parse(Console.ReadLine());
			int workingDays = int.Parse(Console.ReadLine());

			int hoursDone = employees * workingDays * 8;

			int left = Math.Abs(hoursDone - hoursNeeded);
			int penalties = left * workingDays;

			if (hoursNeeded<=hoursDone)
			{
				Console.WriteLine($"{Math.Abs(hoursDone-hoursNeeded)} hours left");
			}
			else
			{
				Console.WriteLine($"{left} overtime\nPenalties: {penalties}");
			}



		}
	}
}
