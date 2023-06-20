using SisServeBem.ConexaoBanco;
using SisServeBem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    class ProdutoDAO : IDAO<Produto>
    {
        private Conexao conexao;
        public ProdutoDAO()
        {
            conexao = new Conexao();
        }

        public void Delete(Produto t)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Produto t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO Produto (nome_pro, valor_venda_pro, valor_custo_pro, marca_pro, tipo_pro) " +
                    "VALUES (@nome, @valorvenda, @valorcusto, @marca, @tipo)";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@valorvenda", t.ValorVenda);
                query.Parameters.AddWithValue("@valorcusto", t.ValorCusto);
                query.Parameters.AddWithValue("@marca", t.Marca);
                query.Parameters.AddWithValue("@tipo", t.Tipo);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Erro ao realizar o cadastro");

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

        public List<Produto> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Produto t)
        {
            throw new NotImplementedException();
        }
    }
}
