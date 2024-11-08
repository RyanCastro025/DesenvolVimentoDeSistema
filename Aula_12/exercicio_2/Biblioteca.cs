using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class Biblioteca
    {

        public List<Livro> estoque = new List<Livro>();

        public void Adicionar_livro(Livro livrinho)
        {
            estoque.Add(livrinho);
        }

        public void Listar_livros()
        {
            foreach(var livro in estoque)
            {
                Console.WriteLine(livro.Titulo +" "+ livro.Ano +" "+ livro.Autor) ;
            }
        }
    }
}
