using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Personagem
    {
       public string Nome { get; set; }
       public int Vida { get; set; }
       public double Altura { get; set; }

         public Personagem(string nome, int vida, double altura)
         {
             Nome = nome;
             Vida = vida;
             Altura = altura;
         }
        public void informacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Vida: {Vida}, Altura: {Altura}");
        }
    }
}
    


