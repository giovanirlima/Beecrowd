// 1015 - Distância Entre Dois Pontos

using System;

class URI
{

    static void Main()
    {

        string[] uri = Console.ReadLine().Split(' ');

        double x1 = double.Parse(uri[0]);
        double y1 = double.Parse(uri[1]);

        uri = Console.ReadLine().Split(' ');

        double x2 = double.Parse(uri[0]);
        double y2 = double.Parse(uri[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(distancia.ToString("F4"));
    }

}