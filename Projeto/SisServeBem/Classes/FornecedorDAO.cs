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
    internal class FornecedorDAO : IDAO<Fornecedor>
    {
        private Conexao conexao;
        public FornecedorDAO()
        {
            conexao = new Conexao();
        }
        public void Delete(Fornecedor t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "DELETE FROM fornecedor WHERE id_for = @id";

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

        public Fornecedor GetById(int id)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "SELECT * FROM fornecedor WHERE id_for = @id";

                query.Parameters.AddWithValue("id", id);

                var resultado = query.ExecuteReader();

                var fornecedor = new Fornecedor();

                while (resultado.Read())
                {
                    fornecedor.Id = resultado.GetInt32("id_for");
                    fornecedor.CNPJ = resultado.GetString("cnpj_for");
                    fornecedor.NomeFantasia = resultado.GetString("nome_fantasia_for");
                    fornecedor.RazaoSocial = resultado.GetString("razao_social_for");
                    fornecedor.Endereco = resultado.GetString("endereco_for");
                    fornecedor.Contato = resultado.GetString("contato_for");
                    
                }

                return fornecedor;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Fornecedor t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO Fornecedor (cnpj_for, nome_fantasia_for, razao_social_for, endereco_for, contato_for) " +
                    "VALUES (@cnpj, @nomefantasia, @razaosocial, @endereco, @contato)";

                query.Parameters.AddWithValue("@cnpj", t.CNPJ);
                query.Parameters.AddWithValue("@nomefantasia", t.NomeFantasia);
                query.Parameters.AddWithValue("@razaosocial", t.RazaoSocial);
                query.Parameters.AddWithValue("@endereco", t.Endereco);
                query.Parameters.AddWithValue("@contato", t.Contato);

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

        public List<Fornecedor> List()
        {
            try
            {
                List<Fornecedor> list = new List<Fornecedor>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM fornecedor";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Fornecedor()
                    {
                        Id = reader.GetInt32("id_for"),
                        CNPJ = DAOHelper.GetString(reader, "cnpj_for"),
                        NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_for"),
                        RazaoSocial = DAOHelper.GetString(reader, "razao_social_for"),
                        Endereco = DAOHelper.GetString(reader, "endereco_for"),
                        Contato = DAOHelper.GetString(reader, "contato_for")

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

        public void Update(Fornecedor t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "UPDATE fornecedor SET cnpj_for, nome_fantasia_for, razao_social_for, endereco_for, contato_for";


                query.Parameters.AddWithValue("@cnpj", t.CNPJ);
                query.Parameters.AddWithValue("@nomefantasia", t.NomeFantasia);
                query.Parameters.AddWithValue("@razaosocial", t.RazaoSocial);
                query.Parameters.AddWithValue("@endereco", t.Endereco);
                query.Parameters.AddWithValue("@contato", t.Contato);

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
