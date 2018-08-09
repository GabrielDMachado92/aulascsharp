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

namespace Eleicao
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Candidato> listCandidato = new List<Candidato>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void efetivaCadastroCandidato_Click(object sender, RoutedEventArgs e)
        {
            Candidato c = new Candidato();

            // validar se todos os campos foram preenchidos
            if (String.IsNullOrEmpty(textBoxMatricula.Text))
            {
                MessageBox.Show("Por favor preencha o campo Matricula");
            }
            else
            {
                c.Matricula = textBoxMatricula.Text;
            }
            if (String.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("Por favor preencha o campo Nome");
            }
            else
            {
                c.Nome = textBoxNome.Text;
            }
            if (!data_de_Nascimento.SelectedDate.HasValue)
            {
                MessageBox.Show("Por favor preencha o Data de Nascimento");
            }
            else
            {
                c.DataNascimento = DateTime.Parse(data_de_Nascimento.Text);
            }

            // salvar aluno em lista
            listCandidato.Add(c);
            c = new Candidato();
            data_de_Nascimento.Text = "";
            textBoxMatricula.Text = "";
            textBoxNome.Text = "";

        }
    }
}
