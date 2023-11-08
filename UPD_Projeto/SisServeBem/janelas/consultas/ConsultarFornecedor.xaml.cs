using SisServeBem.Classes;
using System;
using System.Windows;

namespace SisServeBem
{
    /// <summary>
    /// Lógica interna para ConsultarFornecedor.xaml
    /// </summary>
    public partial class ConsultarFornecedor : Window
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();
            Loaded += ConsultarFornecedor_Loaded;
        }

        private void ConsultarFornecedor_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                var fornecedorDAO = new FornecedorDAO();
                DataGridFornecedor.ItemsSource = fornecedorDAO.List();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
