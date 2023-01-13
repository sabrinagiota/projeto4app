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
using System.Windows.Shapes;

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            string mat = txtMatricula.Text;
            string email = txtEmail.Text;
            int idTurma = int.Parse(txtIdTurma.Text);
            Aluno t = new Aluno 
           
            {

                Id = id,
                Nome = nome,
                Matricula = mat,
                Email = email,
                IdTurma = idTurma,
            
            };

        }
            

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listAlunos.ItemsSource = null;
            listAlunos.ItemsSource = NTurma.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.Id = int.Parse(txtId.Text);
            t.Curso = txtCurso.Text;
            t.Descricao = txtTurma.Text;
            t.AnoLetivo = int.Parse(txtAno.Text);
            NTurma.Atualizar(t);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                NAluno.
            }
        }

        private void listTurmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                Aluno obj = (Aluno)listAlunos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtCurso.Text = obj.Curso;
                txtTurma.Text = obj.Descricao;
                txtAno.Text = obj.AnoLetivo.ToString();
            }
        }
    }
}