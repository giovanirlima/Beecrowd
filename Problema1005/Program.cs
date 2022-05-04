// 1005 - Média 1

using System;

public class Program
{
	public static void Main()
	{

		double N1 = double.Parse(Console.ReadLine());
		double N2 = double.Parse(Console.ReadLine());

		double MEDIA = ((N1 * 3.5) + (N2 * 7.5)) / 11.0;

		Console.WriteLine($"MEDIA = {MEDIA.ToString("F5")}");
	}
}