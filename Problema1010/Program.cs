// 1010 - Cálculo Simples

using System;

class URI
{

    static void Main()
    {

        string[] vet = Console.ReadLine().Split(' ');

        int codPeca1 = int.Parse(vet[0]);
        int numPeca1 = int.Parse(vet[1]);
        double valorPeca1 = double.Parse(vet[2]);

        vet = Console.ReadLine().Split(' ');

        int codPeca2 = int.Parse(vet[0]);
        int numPeca2 = int.Parse(vet[1]);
        double valorPeca2 = double.Parse(vet[2]);

        double total = (numPeca1 * valorPeca1) + (numPeca2 * valorPeca2);

        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");

    }

}