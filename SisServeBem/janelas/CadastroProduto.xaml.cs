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
    /// Lógica interna para CadastroFuncionario.xaml
    /// </summary>
    public partial class CadastroProduto : Window
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void bt_consultar_Click(object sender, RoutedEventArgs e)
        {
            var form = new ConsultarProduto();
            form.ShowDialog();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var pro = new Produto();

                pro.Nome = txtNome.Text;
                pro.ValorVenda = Convert.ToDouble(txtPrecoVenda.Text);
                pro.ValorCusto = Convert.ToDouble(txtPrecoCusto.Text);
                pro.Marca= txtMarca.Text;
                pro.Tipo = txtCategoria.Text;
                pro.Estoque = null;

                var proDAO = new ProdutoDAO();
                proDAO.Insert(pro);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
