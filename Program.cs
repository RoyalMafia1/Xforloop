using System;

class Program
{
    static void Main(string[] args)
    {
        // Küsime kasutajalt ristküliku pikkust ja laiust
        Console.Write("Sisestage ristküliku pikkus: ");
        int pikkus = int.Parse(Console.ReadLine());

        Console.Write("Sisestage ristküliku laius: ");
        int laius = int.Parse(Console.ReadLine());

        // Arvutame pindala ja ümbermõõdu
        int pindala = ArvutaPindala(pikkus, laius);
        int umbermoot = ArvutaUmbermoot(pikkus, laius);

        // Väljastame pindala ja ümbermõõdu
        Console.WriteLine("Ristküliku pindala: " + pindala);
        Console.WriteLine("Ristküliku ümbermõõt: " + umbermoot);

        // Joonistame tühja ristküliku
        JoonistaTuhjaRistkylik(pikkus, laius);
    }

    // Meetod pindala arvutamiseks
    static int ArvutaPindala(int pikkus, int laius)
    {
        return pikkus * laius;
    }

    // Meetod ümbermõõdu arvutamiseks
    static int ArvutaUmbermoot(int pikkus, int laius)
    {
        return 2 * (pikkus + laius);
    }

    // Meetod tühja ristküliku joonistamiseks
    static void JoonistaTuhjaRistkylik(int pikkus, int laius)
    {
        for (int i = 0; i < laius; i++)
        {
            for (int j = 0; j < pikkus; j++)
            {
                if (i == 0 || i == laius - 1 || j == 0 || j == pikkus - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}