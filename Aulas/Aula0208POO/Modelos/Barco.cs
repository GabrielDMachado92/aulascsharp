using Aula0208POO.Modelos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando barco...");
            Velocidade += 12;
        }

        public void Freiar()
        {
            Console.WriteLine("Freiando barco...");
            Velocidade -= 8;
        }
    }
}
