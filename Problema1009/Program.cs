// 1009 - Salário com Bônus

using System;

public class Program
{
	public static void Main()
	{

		string nome = Console.ReadLine();
		double salarioFixo = double.Parse(Console.ReadLine());
		double montanteVendas = double.Parse(Console.ReadLine());

		double total = salarioFixo + (montanteVendas * 0.15);

		Console.WriteLine($"TOTAL = R$ {total.ToString("F2")}");

	}
}