using System;
using Aula0208POO.Modelos.Interfaces;

namespace Aula0208POO.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando carro...");
            Velocidade += 5;
        }

        public void Freiar()
        {
            Console.WriteLine("Freiando carro...");
            Velocidade -= 3;
        }
    }
}
