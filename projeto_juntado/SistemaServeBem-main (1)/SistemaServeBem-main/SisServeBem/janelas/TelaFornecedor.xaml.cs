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
    /// Lógica interna para TelaFornecedor.xaml
    /// </summary>
    public partial class TelaFornecedor : Window
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // botão consultar
            var form = new ConsultarFornecedor();
            form.ShowDialog();

        }
        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomeFantasia.Text == string.Empty || txtCnpj.Text == string.Empty || txtEndereco.Text == string.Empty || txtContato.Text == string.Empty)
            {
                MessageBox.Show(" Termine de preencher todos os campos ♥ ");
            }
            else
            {
                var nomeFantasia = txtNomeFantasia.Text;
                var cnpj = txtCnpj.Text;
                var endereco = txtEndereco.Text;
                var contato = txtContato.Text;


            }

        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            // apagar
            txtCnpj.Clear();
            txtContato.Clear();
            txtEndereco.Clear();
            txtNomeFantasia.Clear();
        }
    }
}
