using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    public class Cliente
    {
        public string Nome {get; set; }
        public List<Reserva> reservas = new List<Reserva>();

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public void criar_eserva(Reserva reserva)
        {
            reserva.Criar_cliente(this);  
            reservas.Add(reserva);       
        }

        public void futuras_reserva()
        {
            Console.WriteLine($"Reservas futuras para o cliente {Nome}:");
            foreach (var reserva in reservas)
            {
                if (reserva.Data > DateTime.Now)
                {
                    Console.WriteLine($"{reserva.Lugar} em {reserva.Data}");
                }
            }
        }
    }
}
