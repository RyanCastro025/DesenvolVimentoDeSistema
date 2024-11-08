using System;

namespace ConsoleApp16
{
    public class Reserva
    {
        public DateTime Data { get; set; }
        public string Lugar { get; set; }
        public Cliente Cliente { get; private set; }

        public Reserva(DateTime data, string lugar)
        {
            Data = data;
            Lugar = lugar;
        }

        public void Criar_cliente(Cliente cliente)
        {
            Cliente = cliente;
        }
    }
}