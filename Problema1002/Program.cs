// 1002 - Área do Círculo
using System.Globalization;


double raio, area, n = 3.14159;

raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = Math.Pow(raio, 2.0) * n;


Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");