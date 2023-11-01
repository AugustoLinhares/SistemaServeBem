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
        /// Lógica interna para CadastroFuncionario.xaml
        /// </summary>
        public partial class CadastroFuncionario : Window
        {
            public CadastroFuncionario()
            {
                InitializeComponent();
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                // consultar
                var form = new ConsultarFuncionario();
                form.ShowDialog();
            }


            private void btSalvar_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    var fun = new Funcionario();

                    fun.Nome = txtNome.Text;
                    fun.CPF = txtCpf.Text;
                    fun.Funcao = txtFuncao.Text;
                    fun.Cidade = txtCidade.Text;
                    fun.UF = txtUf.Text;

                    var funDAO = new FuncionarioDAO();
                    funDAO.Insert(fun);
                    MessageBox.Show("Salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btExcluir_Click(object sender, RoutedEventArgs e)
            {
            }
        }
    }
