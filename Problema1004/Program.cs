﻿// 1004 - Produto Simples

using System;

public class Program
{
	public static void Main()
	{
		int A = int.Parse(Console.ReadLine());
		int B = int.Parse(Console.ReadLine());

		int PROD = A * B;

		Console.WriteLine($"PROD = {PROD}");
	}
}