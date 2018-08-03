using Aula0208POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            car.Modelo = "Ferrari";
            car.Placa = "ABC-1234";
            car.Acelerar();

            Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();

        }
    }
}
