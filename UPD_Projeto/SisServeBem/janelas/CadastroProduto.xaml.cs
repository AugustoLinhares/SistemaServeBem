using MySqlX.XDevAPI;
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
        private Produto _produto = new Produto();


        public CadastroProduto()
        {
            InitializeComponent();
            Loaded += CadastroProduto_Loaded;
        }

        public CadastroProduto(int id)
        {
            InitializeComponent();
            Loaded += CadastroProduto_Loaded;

            _produto.Id = id;
        }

        private void CadastroProduto_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_produto.Id > 0)
                {
                    var produtoDAO = new ProdutoDAO();
                    _produto = produtoDAO.GetById(_produto.Id);

                    txtNome.Text = _produto.Id.ToString();
                    txtMarca.Text = _produto.Marca;
                    txtEstoque.Text = _produto.Estoque.ToString();
                    txtCategoria.Text = _produto.Tipo;
                    txtPrecoCusto.Text = _produto.ValorCusto.ToString();
                    txtPrecoVenda.Text = _produto.ValorVenda.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void bt_consultar_Click(object sender, RoutedEventArgs e)
        {
            var form = new ConsultarProduto();
            form.ShowDialog();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {

            _produto.Nome = txtNome.Text;
            _produto.Marca = txtMarca.Text;
           // _produto.Estoque = txtEstoque.Text;
            _produto.Tipo = txtCategoria.Text;
           // _produto.ValorCusto = txtPrecoCusto.Text;
           // _produto.ValorVenda = txtPrecoVenda.Text;

            try
            {

                var produtoDAO = new ProdutoDAO();

                if (_produto.Id == 0)
                {
                    produtoDAO.Insert(_produto);
                    MessageBox.Show($"Produto {_produto.Nome} adicionado com sucesso!");

                }
                else
                {
                    produtoDAO.Update(_produto);
                    MessageBox.Show($"Produto {_produto.Nome} atualizado com sucesso!");

                }

                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } 
}
