using System;

namespace dogHouse
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double sideAlenth = double.Parse(Console.ReadLine());
			double hightB = double.Parse(Console.ReadLine());

			double sides = sideAlenth * (sideAlenth/2);
			double backT = ((sideAlenth / 2) * (hightB - (sideAlenth / 2))) / 2;
			double back = ((sideAlenth / 2) * (sideAlenth / 2)) + backT;
			double entrance = (sideAlenth / 5) * (sideAlenth / 5);
			double front = back - entrance;

			double roof = 2 * (sideAlenth * (sideAlenth / 2));

			double green = sides * 2 + back + front;
			double red = roof;

			double greenPaint = green / 3;
			double redPaint = red / 5;

			Console.WriteLine($"{greenPaint:f2}\n{redPaint:f2}");

		}
	}
}
