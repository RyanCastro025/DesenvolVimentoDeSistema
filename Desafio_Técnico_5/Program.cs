using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {             
            Personagem personagem1 = new Personagem("Mario", 100, 1.50);
            Personagem personagem2 = new Personagem("Luigi", 90, 1.70);
            personagem1.informacoes();
            personagem1.informacoes();
            Console.ReadKey(); 
        }
    }
}
