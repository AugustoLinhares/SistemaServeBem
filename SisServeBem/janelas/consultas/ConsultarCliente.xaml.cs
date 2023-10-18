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
using System.Windows.Shapes;

namespace SisServeBem
{
    /// <summary>
    /// Lógica interna para ConsultarCliente.xaml
    /// </summary>
    public partial class ConsultarCliente : Window
    {

        public ConsultarCliente()
        {
            InitializeComponent();
            Loaded += ConsultarCliente_Loaded;
        }

        private void ConsultarCliente_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                var clienteDAO = new ClienteDAO();
                dataGridCliente.ItemsSource = clienteDAO.List();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // bt seta

            var form = new CadastroCliente();
            form.ShowDialog();
        }

        private void btEditar_Click(object sender, RoutedEventArgs e)
        {
            var clienteSelecionado = dataGridCliente.SelectedItem as Cliente;
            var tela = new CadastroCliente(clienteSelecionado.Id);
            tela.ShowDialog();
            CarregarDados();
        }

        private void btDeletar_Click(object sender, RoutedEventArgs e)
        {
            var clienteSelecionado = dataGridCliente.SelectedItem as Cliente;

            var result = MessageBox.Show($"Deseja realmente remover o Cliente `{clienteSelecionado.Nome}`?", "Confirmação de Exclusão",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);

            try
            {
                if (result == MessageBoxResult.Yes)
                {
                    var dao = new ClienteDAO();
                    dao.Delete(clienteSelecionado);
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
