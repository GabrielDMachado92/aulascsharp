using Aula0208POO.Modelos;
using Aula0208POO.Modelos.Interfaces;
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

            ExecutaTesteMotor(car);

            //Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();

        }

        static void ExecutaTesteMotor(IMotorizado vec)
        {
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Freiar();
            vec.Freiar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
        }
    }
}
