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

namespace SisServeBem.janelas
{
    /// <summary>
    /// Interaction logic for TelaVendas.xaml
    /// </summary>
    public partial class TelaVendas : Window
    {
        private Venda _venda = new Venda();
        public TelaVendas()
        {
            InitializeComponent();
            CarregarTela();
        }

        private void CarregarTela()
        {
            dtpDataVenda.SelectedDate = DateTime.Now;

            try
            {
                comboBoxFuncionario.ItemsSource = new FuncionarioDAO().List();
                comboBoxCliente.ItemsSource = new ClienteDAO().List();
                comboBoxMesa.ItemsSource = new MesaDAO().ListVazia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAdicionarProd_Click(object sender, RoutedEventArgs e)
        {
            var window = new TelaAdicionarProdutos();
            window.ShowDialog();

            //var produtosSelecionadosList = window.ProdutosSelecionados;
            //var count = 1;

            //foreach (Produto produto in produtosSelecionadosList)
            //{

            //    if (!_compraItensList.Exists(item => item.Produto.Id == produto.Id))
            //    {
            //        _compraItensList.Add(new CompraItem()
            //        {
            //            Id = count,
            //            Produto = produto,
            //            Quantidade = 1,
            //            Valor = produto.ValorCompra,
            //            ValorTotal = produto.ValorCompra
            //        });

            //        count++;
            //    }
            //}

            //LoadDataGrid();
        }
    }
}
