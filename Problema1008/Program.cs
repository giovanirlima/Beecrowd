// 1008 - Salário

using System;

public class Program
{
	public static void Main()
	{

		int num = int.Parse(Console.ReadLine());
		int horas = int.Parse(Console.ReadLine());
		double vlPorHora = double.Parse(Console.ReadLine());

		double salario = horas * vlPorHora;


		Console.WriteLine($"NUMBER = {num}");
		Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
	}
}