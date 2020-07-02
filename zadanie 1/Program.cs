using System;


namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во бросков монетки");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вероятность выпадения стороны с гербом");
            int e = Convert.ToInt32(Console.ReadLine());
            Double n = Math.Pow(2, q);
            int r = q - e;
            int t = q;
            int fact1 = 1;
            for (int i=2; i<=t; i++)
            {
                fact1 = fact1 * i;
            }
            int y = e;
            int fact2 = 1;
            for(int i = 2; i<=e; i++)
            {
                fact2 = fact2 * i;
            }
            int z = r;
            int fact3 = 1;
            for(int i=2; i<=r; i++)
            {
                fact3 = fact3 * i;
            }
            Double m = fact1 / (fact2 * fact3);
            Double P = m / n;
            Console.WriteLine($"Ответ:{P}%");
            P = Math.Round(P, 2);
            Console.ReadKey();


        }

    }
}
