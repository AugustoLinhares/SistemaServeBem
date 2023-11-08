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
            throw new NotImplementedException();
        }

        public Fornecedor GetById(int id)
        {
            throw new NotImplementedException();
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
                query.CommandText = "SELECT * FROM Fornecedor";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Fornecedor()
                    {
                        Id = reader.GetInt32("id_for"),
                        RazaoSocial = DAOHelper.GetString(reader, "razao_social_for"),
                        CNPJ = DAOHelper.GetString(reader, "cnpj_for"),
                        NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_for"),
                        Contato = DAOHelper.GetString(reader, "contato_for" +
                        ""),
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
            throw new NotImplementedException();
        }
    }
}
