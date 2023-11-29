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

    namespace SisServeBem.janelas
    {
        /// <summary>
        /// Lógica interna para CadastroFuncionario.xaml
        /// </summary>
        public partial class CadastroFuncionario : Window
        {
        private Funcionario _funcionario = new Funcionario();

        public CadastroFuncionario()
            {
                InitializeComponent();
                Loaded += CadastroFuncionario_Loaded;
            }

            public CadastroFuncionario(int id)
            {
                InitializeComponent();
                Loaded += CadastroFuncionario_Loaded;

                _funcionario.Id = id;

            }

        private void CadastroFuncionario_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

                if (_funcionario.Id > 0)
                {
                    var funcionarioDAO = new FuncionarioDAO();
                    _funcionario = funcionarioDAO.GetById(_funcionario.Id);

                    txtNome.Text = _funcionario.Id.ToString();
                    txtCpf.Text = _funcionario.CPF;
                    txtFuncao.Text = _funcionario.Funcao;
                    txtUf.Text = _funcionario.UF;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
            {
                // consultar
                var form = new ConsultarFuncionario();
                form.ShowDialog();
            }


            private void btSalvar_Click(object sender, RoutedEventArgs e)
            {

            _funcionario.Nome = txtNome.Text;
            _funcionario.CPF = txtCpf.Text;
            _funcionario.UF = txtUf.Text;
            _funcionario.Funcao = txtFuncao.Text;

            try
            {

                var funcionarioDAO = new FuncionarioDAO();

                if (_funcionario.Id == 0)
                {
                    funcionarioDAO.Insert(_funcionario);
                    MessageBox.Show($"Cliente {_funcionario.Nome} adicionado com sucesso!");

                }
                else
                {
                    funcionarioDAO.Update(_funcionario);
                    MessageBox.Show($"Cliente {_funcionario.Nome} atualizado com sucesso!");

                }

                this.Close();
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
