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
        private Cliente _cliente = new Cliente();

        public CadastroCliente()
        {
            InitializeComponent();
            Loaded += CadastrarCliente_Loaded;
        }

        public CadastroCliente(int id)
        {
            InitializeComponent();
            Loaded += CadastrarCliente_Loaded;
            _cliente.Id = id;
        }

        private void CadastrarCliente_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
               // comboBoxEstado.ItemsSource = Estado.List();

                if (_cliente.Id > 0)
                {
                    var clienteDAO = new ClienteDAO();
                    _cliente = clienteDAO.GetById(_cliente.Id);

                    txtCidade.Text = _cliente.Id.ToString();
                     txtNome.Text = _cliente.Nome;
                     txtCPF.Text = _cliente.CPF;
                     txtNumero.Text = _cliente.Numero;
                     txtEmail.Text = _cliente.Email;
                     txtCidade.Text =   _cliente.Cidade;
                     txtEndereco.Text = _cliente.Endereco;

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro");
            }
        }


        private void bt_consultar_Click(object sender, RoutedEventArgs e)
        {
            var form = new ConsultarCliente();
            form.ShowDialog();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {

            _cliente.Nome = txtNome.Text;
            _cliente.CPF = txtCPF.Text;
            _cliente.Numero = txtNumero.Text;
            _cliente.Email = txtEmail.Text;
            _cliente.Cidade = txtCidade.Text;
            _cliente.Endereco = txtEndereco.Text;

            try
            {               

                var clienteDAO = new ClienteDAO();

                if (_cliente.Id == 0)
                {
                    clienteDAO.Insert(_cliente);
                    MessageBox.Show($"Cliente {_cliente.Nome} adicionado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Numero} adicionado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Email} adicionado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Endereco} adicionado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Cidade} adicionado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.CPF} adicionado com sucesso!");

                }
                else
                {
                    clienteDAO.Update(_cliente);
                    MessageBox.Show($"Cliente {_cliente.Nome} atualizado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Numero} atualizado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Email} atualizado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Endereco} atualizado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.Cidade} atualizado com sucesso!");
                    MessageBox.Show($"Cliente {_cliente.CPF} atualizado com sucesso!");

                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
