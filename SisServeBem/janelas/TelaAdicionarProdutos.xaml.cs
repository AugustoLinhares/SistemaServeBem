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
using SisServeBem.Classes;

namespace SisServeBem.janelas
{
    /// <summary>
    /// Interaction logic for TelaAdicionarProdutos.xaml
    /// </summary>
    public partial class TelaAdicionarProdutos : Window
    {
        private List<Produto> _produtosList = new List<Produto>();

        /*public List<Produto> ProdutosSelecionados { get; private set; } = new List<Produto>();*/
        public TelaAdicionarProdutos()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            try
            {
                dataGrid.ItemsSource = new ProdutoDAO().List();

            }
            catch (Exception ex)
            {
            }
        }

        private void BtnAdicionarProdutos_Click(object sender, RoutedEventArgs e)
        {
            var itens = dataGrid.Items;
            //ProdutosSelecionados.Clear();

            //foreach (Produto produto in itens)
            //{
            //    if (produto.IsSelected)
            //        ProdutosSelecionados.Add(produto);
            //}

            //if (ProdutosSelecionados.Count == 0)
            //    MessageBox.Show("Nenhum produto foi selecionado!", "", MessageBoxButton.OK, MessageBoxImage.Information);

           this.Close();
        }
    }
}
