using System;

class Program
{
    static void Main(string[] args)
    {
        for (; ; )
        {
            int a, b;


            Console.WriteLine("Digite o A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o B:");
            b = int.Parse(Console.ReadLine());


            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos");
            }
            Console.WriteLine();
        }
    }
}