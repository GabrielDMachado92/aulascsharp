﻿using System;
using Aula0208POO.Modelos.Interfaces;

namespace Aula0208POO.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
            Velocidade += 5;
        }

        public void Freiar()
        {
            Console.WriteLine("Freiando...");
            Velocidade -= 3;
        }
    }
}
