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
    /// Lógica interna para menuWPF.xaml
    /// </summary>
    public partial class menuWPF : Window
    {
        public menuWPF()
        {
            InitializeComponent();

        }

        private void bt_fornecedor_Click(object sender, RoutedEventArgs e)
        {
            var form = new TelaFornecedor();
            form.ShowDialog();
        }

        private void bt_funcionario_Click(object sender, RoutedEventArgs e)
        {
            var form = new CadastroFuncionario();
            form.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // botão produto
            var form = new CadastroProduto();
            form.ShowDialog();
        }

        private void bt_cliente_Click(object sender, RoutedEventArgs e)
        {
            var form = new CadastroCliente();
            form.ShowDialog();
        }
    }
}
