using System;

namespace carToGo
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();

			double price = 0;
			string classOfCar = "";
			string carType = "";

			switch (season.ToLower())
			{
				case "winter":
					carType = "Jeep";
					if (budget<=100)
					{
						classOfCar = "Economy class";
						price = budget*65/100;
					}
					if (budget>100&&budget<=500)
					{
						classOfCar = "Compact class";
						price = budget * 80 / 100;
					}
					if (budget>500)
					{
						classOfCar = "Luxury class";
						price = budget * 90 / 100;
					}break;
				case "summer":
					carType = "Cabrio";
					if (budget <= 100)
					{
						classOfCar = "Economy class";
						price = budget * 35 / 100;
					}
					if (budget > 100 && budget <= 500)
					{
						classOfCar = "Compact class";
						price = budget * 45 / 100;
					}
					if (budget > 500)
					{
						classOfCar = "Luxury class";
						price = budget * 90 / 100;
						carType = "Jeep";
					}
					break;
				default:
					break;
			}

			Console.WriteLine($"{classOfCar}\n{carType} - {price:f2}");


		}
	}
}
