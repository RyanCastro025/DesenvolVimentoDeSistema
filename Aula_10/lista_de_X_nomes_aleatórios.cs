using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string> {
            "sergio", "ana", "maria", "carlos", "eva",
            "joaquim", "jo", "mara", "laura", "lucas",
            "ari", "paulo"
        };

        var orndem_nome = nomes
            .OrderBy(n => n.Length)
            .ThenBy(n => nomes.IndexOf(n))
            .ToList();

        List<string> linhasSaida = new List<string>();

    
        Dictionary<int, int> contadorPorTamanho = new Dictionary<int, int>();

        foreach (var nome in orndem_nome)
        {
            int tamanho = nome.Length;
            if (!contadorPorTamanho.ContainsKey(tamanho))
            {
                contadorPorTamanho[tamanho] = 0;
            }
            int index = contadorPorTamanho[tamanho];            
            if (index >= linhasSaida.Count)
            {
                linhasSaida.Add(nome);
            }
            else
            {
                linhasSaida[index] += ", " + nome;
            }
            contadorPorTamanho[tamanho]++;
        }

        
        foreach (var linha in linhasSaida)
        {
            Console.WriteLine(linha);
        }
        Console.ReadKey();
    }
}