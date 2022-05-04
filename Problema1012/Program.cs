// 1012 - Área

using System;
using System.Globalization;

class URI
{

    static void Main()
    {

        string[] vet = Console.ReadLine().Split(' ');

        double pi = 3.14159;

        double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double C = double.Parse(vet[2], CultureInfo.InvariantCulture);


        double triangulo = A * C / 2;
        double circulo = pi * C * C;
        double trapezio = (A + B) * C / 2;
        double quadrado = Math.Pow(B, 2);
        double retangulo = A * B;


        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

    }

}