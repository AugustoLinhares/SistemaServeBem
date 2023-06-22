using SisServeBem.Classes;
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

namespace SisServeBem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void bt_consultar_Click(object sender, RoutedEventArgs e)
        {
            var form = new ConsultarCliente();
            form.ShowDialog();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var cli = new Cliente();

                cli.Nome = txtNome.Text;
                cli.CPF = txtCPF.Text;
                cli.Numero = txtNumero.Text;
                cli.Email = txtEmail.Text;
                cli.Cidade = txtCidade.Text;
                cli.Endereco = txtEndereco.Text;

                var cliDAO = new ClienteDAO();
                cliDAO.Insert(cli);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
