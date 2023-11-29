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

namespace SisServeBem.janelas
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btFuncionario_Click(object sender, RoutedEventArgs e)
        {
            var func = new CadastroFuncionario();
            func.ShowDialog();
        }

        private void btFinanceiro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btFornecedor_Click(object sender, RoutedEventArgs e)
        {
            var forn = new TelaFornecedor();
            forn.ShowDialog();
        }

        private void btEstoque_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btVendas_Click(object sender, RoutedEventArgs e)
        {
            var vend = new TelaVendas();
            vend.ShowDialog();
        }

        private void btRelatorio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btClientes_Click(object sender, RoutedEventArgs e)
        {
            var clie = new CadastroCliente();
            clie.ShowDialog();
        }

        private void btProdutos_Click(object sender, RoutedEventArgs e)
        {
            var prod = new CadastroProduto();
            prod.ShowDialog();
        }
    }
}
