using System;

//1
//class Program
//{
//	static void Main()
//	{
//		Console.Write("Введите сумму выдачи (от 1 до 9999): ");
//		int amount = int.Parse(Console.ReadLine());
//
//		if (amount < 1 || amount > 9999)
//		{
//			Console.WriteLine("Число должно быть в диапазоне от 1 до 9999");
//			return;
//		}
//
//		string currency = GetCurrencyString(amount);
//		Console.WriteLine($"{amount} {currency}");
//	}
//
//	static string GetCurrencyString(int amount)
//	{
//		int remainder10 = amount % 10;
//		int remainder100 = amount % 100;
//
//		if (remainder100 >= 11 && remainder100 <= 14)
//		{
//			return "долларов";
//		}
//
//		switch (remainder10)
//		{
//			case 1:
//				return "доллар";
//			case 2:
//			case 3:
//			case 4:
//				return "доллара";
//			default:
//				return "долларов";
//		}
//	}
//}
//

//2
//class Program
//{
//	static void Main()
//	{
//		Console.Write("Введите число: ");
//		int number = int.Parse(Console.ReadLine());
//
//		if (number < 2)
//		{
//			Console.WriteLine($"{number} не является простым числом.");
//			return;
//		}
//
//		bool isPrime = true;
//
//		for (int i = 2; i <= Math.Sqrt(number); i++)
//		{
//			if (number % i == 0)
//			{
//				isPrime = false;
//				break;
//			}
//		}
//
//		if (isPrime)
//		{
//			Console.WriteLine($"{number} является простым числом.");
//		}
//		else
//		{
//			Console.WriteLine($"{number} не является простым числом.");
//		}
//	}
//}

//3
//class Program
//{
//	static void Main()
//	{
//		Console.Write("Введите число: ");
//		int number = int.Parse(Console.ReadLine());
//
//		Console.Write("Цифры числа справа налево: ");
//
//		while (number != 0)
//		{
//			int digit = number % 10;
//			Console.Write(digit); 
//			number /= 10;
//		}
//
//		Console.WriteLine();
//	}
//}

//4

//class Program
//{
//	static void Main()
//	{
//		Console.Write("Введите число: ");
//		int number = int.Parse(Console.ReadLine());
//		int originalNumber = number;
//		int sum = 0;
//		int numberOfDigits = number.ToString().Length;
//
//		for (int i = 0; i < numberOfDigits; i++)
//		{
//			int digit = number % 10;
//			sum += (int)Math.Pow(digit, numberOfDigits);
//			number /= 10;
//		}
//		if (sum == originalNumber)
//		{
//			Console.WriteLine($"{originalNumber} является числом Армстронга.");
//		}
//		else
//		{
//			Console.WriteLine($"{originalNumber} не является числом Армстронга.");
//		}
//	}
//}