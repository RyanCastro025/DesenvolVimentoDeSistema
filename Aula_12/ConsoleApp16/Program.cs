using System;

namespace ConsoleApp16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Ryan");
            cliente.criar_eserva(new Reserva(DateTime.Now.AddDays(3), "Reserva hotel 1"));
            cliente.criar_eserva(new Reserva(DateTime.Now.AddDays(6), "Reserva hotel 2"));
            cliente.criar_eserva(new Reserva(DateTime.Now.AddDays(9), "Reserva hotel 3"));
            cliente.futuras_reserva();
            Console.ReadKey();
        }
    }
}
