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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // consultar
            var form = new ConsultarCliente();
            form.ShowDialog();
        }
    }
}
