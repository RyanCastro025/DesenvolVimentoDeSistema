using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double somar = 0;
            int cont_total = 0;
            int cont_par = 0;
            double media;

            Console.WriteLine("Entre com sua quantidade de NUmeros");
            int quantidade = int.Parse(Console.ReadLine());

            while(cont_total < quantidade)
            {
                Console.WriteLine("Enstre com seus números");
                int numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    somar += numero;
                    cont_par++;
                }
                cont_total++;

            }
            media = somar / cont_par;
            Console.WriteLine("Sua média é:" + media);
            Console.ReadKey();
        }
    }
}
