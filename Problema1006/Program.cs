// 1006 - Média 2

using System;

public class Program
{
	public static void Main()
	{

		double N1 = double.Parse(Console.ReadLine());
		double N2 = double.Parse(Console.ReadLine());
		double N3 = double.Parse(Console.ReadLine());

		double MEDIA = ((N1 * 2.0) + (N2 * 3.0) + (N3 * 5.0)) / 10.0;

		Console.WriteLine($"MEDIA = {MEDIA.ToString("F1")}");
	}
}