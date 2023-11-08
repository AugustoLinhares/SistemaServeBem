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
    class ProdutoDAO : IDAO<Produto>
    {
        private Conexao conexao;
        public ProdutoDAO()
        {
            conexao = new Conexao();
        }

        public void Delete(Produto t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "DELETE FROM produto WHERE id_pro = @id";

                query.Parameters.AddWithValue("@id", t.Id);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Registro não removido da base de dados. Verifique e tente novamente.");

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

        public Produto GetById(int id)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "SELECT * FROM produto WHERE id_pro = @id";

                query.Parameters.AddWithValue("id", id);

                var resultado = query.ExecuteReader();

                var produto = new Produto();

                while (resultado.Read())
                {
                    produto.Id = resultado.GetInt32("id_pro");
                    produto.Nome = resultado.GetString("nome_pro");
                    produto.ValorVenda = resultado.GetDouble("valor_venda_pro");
                    produto.ValorCusto = resultado.GetDouble("valor_custo_pro");
                    produto.Marca = resultado.GetString("marca_pro");
                    produto.Tipo = resultado.GetString("tipo_pro");
                }

                return produto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                List<Produto> list = new List<Produto>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM produto";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Produto()
                    {
                        Id = reader.GetInt32("id_pro"),
                        Nome = DAOHelper.GetString(reader, "nome_pro"),
                        ValorVenda = DAOHelper.GetDouble(reader, "valor_venda_pro"),
                        ValorCusto = DAOHelper.GetDouble(reader, "valor_custo_pro"),
                        Marca = DAOHelper.GetString(reader, "marca_pro"),
                        Tipo = DAOHelper.GetString(reader, "tipo_pro")

                    });
                }

                return list;
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

        public void Update(Produto t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "UPDATE produto SET nome_pro = @nome_pro, valor_venda_pro = @valor_venda_pro, valor_custo_pro = @valor_custo_pro, " +
                "marca_pro = @marca_pro, tipo_pro = @tipo_pro";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@valorvenda", t.ValorVenda);
                query.Parameters.AddWithValue("@valorcusto", t.ValorCusto);
                query.Parameters.AddWithValue("@marca", t.Marca);
                query.Parameters.AddWithValue("@tipo", t.Tipo);

                query.Parameters.AddWithValue("@Id", t.Id);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Erro ao realizar o cadastro");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
