// 1011 - Esfera

using System;

class URI
{

    static void Main()
    {

        double R = double.Parse(Console.ReadLine());

        double pi = 3.14159;

        double V = (4 / 3.0) * pi * Math.Pow(R, 3.0);

        Console.WriteLine($"VOLUME = {V.ToString("F3")}");

    }

}