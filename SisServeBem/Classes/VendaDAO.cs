using MySql.Data.MySqlClient;
using SisServeBem.ConexaoBanco;
using SisServeBem.helpers;
using SisServeBem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SisServeBem.Classes
{
    class VendaDAO : IDAO<Venda>
    {
        private Conexao conexao;
        public VendaDAO()
        {
            conexao = new Conexao();
        }
        public void Delete(Venda t)
        {
            throw new NotImplementedException();
        }
        public Venda GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Insert(Venda t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO Venda (data_ven, valor_ven, id_cli_fk, id_ped_fk, id_fun_fk) " +
                    "VALUES (@data, @valor, @cliente, @pedido, @funcionario)";
                query.Parameters.AddWithValue("@data", t.Data.ToString("yyyy-MM-dd"));
                query.Parameters.AddWithValue("@valor", t.Valor);
                query.Parameters.AddWithValue("@cliente", t.Cliente.Id);
                query.Parameters.AddWithValue("@pedido", t.Pedido.Id);
                query.Parameters.AddWithValue("@funcionario", t.Funcionario.Id);
                var result = query.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("Erro ao realizar o cadastro");
                }
                    
                long compraId = query.LastInsertedId;

                VendaProduto(compraId, t.Itens);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }
        private void VendaProduto(long compraId, List<VendaProduto> prod)
        {
            foreach (VendaProduto item in prod)
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO Venda_Produto (id_ven_fk, id_pro_fk, qtd_ven_pro) VALUES (@venda, @produto, @quantidade)";
                query.Parameters.AddWithValue("@compra", compraId);
                query.Parameters.AddWithValue("@produto", item.Produto.Id);
                query.Parameters.AddWithValue("@quantidade", item.Quantidade);
                var result = query.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("Os itens da compra não foram adicionados. Verifique e tente novamente.");
                }
            }
        }
        public List<Venda> List()
        {
            throw new NotImplementedException();
        }
        public void Update(Venda t)
        {
            throw new NotImplementedException();
        }
    }
}