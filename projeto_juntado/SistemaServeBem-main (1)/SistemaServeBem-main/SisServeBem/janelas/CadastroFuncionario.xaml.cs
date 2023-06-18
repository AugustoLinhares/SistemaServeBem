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

namespace SisServeBem
{
    /// <summary>
    /// Lógica interna para CadastroFuncionario.xaml
    /// </summary>
    public partial class CadastroFuncionario : Window
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // consultar
            var form = new ConsultarFuncionario();
            form.ShowDialog();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == string.Empty || txtNumero.Text == string.Empty || txtEndereco.Text == string.Empty || txtEmail.Text == string.Empty || txtCpf.Text == string.Empty)
            {
                MessageBox.Show(" Termine de preencher todos os campos ♥ ");
            }
            else
            {
                var nome = txtNome.Text;
                var numero = txtNumero.Text;
                var endereco = txtEndereco.Text;
                var email = txtEmail.Text;
                var cpf = txtCpf.Text;


            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Clear();
            txtNumero.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
        }
    }
}
