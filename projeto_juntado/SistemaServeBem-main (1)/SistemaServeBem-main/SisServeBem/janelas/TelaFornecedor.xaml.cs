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
    }
}
