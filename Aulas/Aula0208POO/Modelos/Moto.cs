using Aula0208POO.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        
        public string Cor { get; set; }
        public int Velocidade { get; set ; }

        public void Acelerar()
        {
            Console.WriteLine("MOTO Acelerando...");
            Velocidade += 7;
        }

        public void Freiar()
        {
            Console.WriteLine("MOTO Freiando...");
            Velocidade -= 4;
        }
    }
}
