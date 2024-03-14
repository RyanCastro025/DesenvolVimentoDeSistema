using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            Console.WriteLine("Escolha sua Classe:");
            Console.WriteLine("1-Guerreira");
            Console.WriteLine("2-Mago");
            Console.WriteLine("3-Arqueiro");
            escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Guerreira:Ataque Pesado, Defesa Total ");
                    break;
                case 2:
                    Console.WriteLine("Mago: Bola de Fogo, Escudo de Gelo ");
                    break;
                case 3:
                    Console.WriteLine("Arqueiro: Flecha Precisa, Disparo Triplo ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
