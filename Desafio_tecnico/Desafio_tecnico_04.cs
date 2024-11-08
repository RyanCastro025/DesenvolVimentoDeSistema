using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static desafio_técnico_04.Program;

namespace desafio_técnico_04
{
    internal class Program
    {
        public class Amigo
        {
            public string nome;
            public int idade;
            public string cpf;
            public List<string> qualidades;

            public Amigo(string nome_novo, int idade_novo, string cpf_novo, List<string> qualidades_novo)
            {
                nome = nome_novo;
                idade = idade_novo;
                qualidades = qualidades_novo;
                cpf = cpf_novo;

            }

            public override string ToString()
            {
                return $"Nome: {nome}, Idade: {idade}, Cpf:{cpf} Qualidades: {string.Join(", ", qualidades)}";
            }
        }
        static void Main(string[] args)
        {
            List<Amigo> amigo_3 = new List<Amigo>();

            amigo_3.Add(new Amigo("Mário", 35, "420696-78", new List<string> { "Excelente encanador", "muito corajoso." }));
            amigo_3.Add(new Amigo("Luidi", 37, "767572-89", new List<string> { "Excelente exterminador de fantasma", "muito medroso." }));
            amigo_3.Add(new Amigo("Princesa ", 26, "Não identificado", new List<string> { "melhor rainha do reino do cogumelo", "" }));

            Console.WriteLine("                                   //Pasta restrita // Informações altamente restrita//");
            Console.WriteLine();

            foreach (Amigo amigo in amigo_3)
            {
                Console.WriteLine(amigo);
            }
            Console.ReadKey(); // sem essa linha o codigo nao roda no meu pc
        }

    }
}
