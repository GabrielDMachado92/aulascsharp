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

namespace SistemaEscolar
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

        List<Aluno> listaAluno = new List<Aluno>();

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Aluno a = new Aluno();


            // validar se todos os campos foram preenchidos
            if (String.IsNullOrEmpty(textBoxMatricula.Text))
            {
                MessageBox.Show("Por favor preencha o campo Matricula");
            } else
            {
                a.matricula = textBoxMatricula.Text;
            }
            if (String.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("Por favor preencha o campo Nome");
            } else
            {
                a.nomeAluno = textBoxNome.Text;
            }
            if (!data_de_Nascimento.SelectedDate.HasValue)
            {
                MessageBox.Show("Por favor preencha o Data de Nascimento");
            } else
            {
                a.dataNascimento = DateTime.Parse(data_de_Nascimento.Text);
            }
            // salvar aluno em lista
            listaAluno.Add(a);
            a = new Aluno();
            data_de_Nascimento.Text = "";
            textBoxMatricula.Text = "";
            textBoxNome.Text = "";

            MessageBox.Show("Aluno cadastrado com sucesso");


        }
    }
}
