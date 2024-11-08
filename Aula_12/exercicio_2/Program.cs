using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b1 = new Biblioteca();
            Livro l1 = new Livro("abc","juninho do grau",1750);

            b1.Adicionar_livro(l1);

            b1.Listar_livros();


            Console.ReadKey();
        }
    }
}
