// 1014 - Consumo

using System;

class URI
{

    static void Main()
    {
        int X = int.Parse(Console.ReadLine());

        double Y = double.Parse(Console.ReadLine());

        double consumoMedio = X / Y;

        Console.WriteLine($"{consumoMedio.ToString("F3")} km/l");

    }

}