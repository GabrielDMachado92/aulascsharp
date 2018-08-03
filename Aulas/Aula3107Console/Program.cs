using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107Console
{
    class Program
    {
        public static int num1;

        public static int num2;

        public static int res;

        public static int opt;

        public static String optstr;

        static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("Digite o número da operação");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                opt = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro numero");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                num2 = int.Parse(Console.ReadLine());

                if (opt == 0)
                {
                    break;
                }

                if (opt == 1)
                {
                    res = num1 + num2;
                    optstr = "Soma";
                }
                else if (opt == 2)
                {
                    res = num1 - num2;
                    optstr = "Subtração";
                }
                else if (opt == 3)
                {
                    res = num1 * num2;
                    optstr = "Multiplicação";
                }
                else if (opt == 4)
                {
                    res = num1 / num2;
                    optstr = "Divisão";
                }

                Console.WriteLine("O resultado da sua operação de " + optstr + " é: " + res);
                Console.ReadKey();

            }

        }
    }
}
