using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aula0708_WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double operador1 = 0, operador2 = 0, resultadoFinal = 0;
        private bool isOper, primeiroNum = true;
        private string operacao;

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "1";
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "2";
        }

        private void num3_Click_1(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "3";
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "4";
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "5";
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "6";
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "7";
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "8";
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "9";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            primeiroNum = true;
        }

        private void soma_Click(object sender, RoutedEventArgs e)
        {
            operador1 = Double.Parse(textBox.Text);
            textBox.Text = "+";
            operacao = "+";
        }

        private void subtracao_Click(object sender, RoutedEventArgs e)
        {
            operador1 = Double.Parse(textBox.Text);
            textBox.Text = "-";
            operacao = "-";
        }

        private void divisao_Click(object sender, RoutedEventArgs e)
        {
            operador1 = Double.Parse(textBox.Text);
            textBox.Text = "/";
            operacao = "/";
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + "0";

        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            isOper = validaOperacao(textBox.Text);
            if (isOper)
            {
                textBox.Text = "";
                primeiroNum = false;
            }
            textBox.Text = textBox.Text + ",";
        }

        private void raiz_Click(object sender, RoutedEventArgs e)
        {
            operador1 = Double.Parse(textBox.Text);
            textBox.Text = "raiz";
            operacao = "raiz";
        }

        private void potencia_Click(object sender, RoutedEventArgs e)
        {
            operador1 = Double.Parse(textBox.Text);
            textBox.Text = "potencia";
            operacao = "potencia";
        }

        private void multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            operador1 = Double.Parse(textBox.Text);
            textBox.Text = "*";
            operacao = "*";
        }

        public bool validaOperacao(String oper)
        {
            if (oper.Equals("+") || oper.Equals("-") || oper.Equals("/") || oper.Equals("*") || oper.Equals("raiz") || oper.Equals("potencia"))
            {
                return true;
            }
            return false;
        }

        private void resultado_Click(object sender, RoutedEventArgs e)
        {
            if (primeiroNum)
            {
                MessageBox.Show("Digite o segundo numero e/ou operacao");
            }
            else if (operacao.Equals("+"))
            {
                operador2 = Double.Parse(textBox.Text);
                resultadoFinal = operador1 + operador2;
                textBox.Text = resultadoFinal.ToString();
            }
            else if (operacao.Equals("-"))
            {
                operador2 = Double.Parse(textBox.Text);
                resultadoFinal = operador1 - operador2;
                textBox.Text = resultadoFinal.ToString();
            }
            else if (operacao.Equals("/"))
            {
                operador2 = Double.Parse(textBox.Text);
                resultadoFinal = operador1 / operador2;
                textBox.Text = resultadoFinal.ToString();
            }
            else if (operacao.Equals("*"))
            {
                operador2 = Double.Parse(textBox.Text);
                resultadoFinal = operador1 * operador2;
                textBox.Text = resultadoFinal.ToString();
            }
            else if (operacao.Equals("raiz"))
            {
                operador2 = Double.Parse(textBox.Text);
                resultadoFinal = Math.Pow(operador1, 1 / operador2);
                textBox.Text = resultadoFinal.ToString();
            }
            else if (operacao.Equals("potencia"))
            {
                operador2 = Double.Parse(textBox.Text);
                resultadoFinal = Math.Pow(operador1 , operador2);
                textBox.Text = resultadoFinal.ToString();
            }
        }
    }
}
