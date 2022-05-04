// 1013 - O Maior

using System;

class URI
{

    static void Main()
    {
        int maior = 0;

        string[] uri = Console.ReadLine().Split(' ');

        for (int i = 0; i < 3; i++)
        {
            if (int.Parse(uri[i]) > maior)
                maior = int.Parse(uri[i]);
        }

        Console.WriteLine($"{maior} eh o maior");
    }

}