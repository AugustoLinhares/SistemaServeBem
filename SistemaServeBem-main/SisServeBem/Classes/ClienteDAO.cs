using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Tls;
using SisServeBem.ConexaoBanco;
using SisServeBem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    class ClienteDAO : IDAO<Cliente>
    {
        private Conexao conexao;
        public ClienteDAO()
        {
            conexao = new Conexao();
        }

        public void Delete(Cliente t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "DELETE FROM cliente WHERE id_cli = @id";

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

        public Cliente GetById(int id)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "SELECT * FROM cliente WHERE id_cli = @id";

                query.Parameters.AddWithValue("id", id);

                var resultado = query.ExecuteReader();

                var cliente = new Cliente();

                while (resultado.Read())
                {
                    cliente.Id = resultado.GetInt32("id_cli");
                    cliente.Nome = resultado.GetString("nome_cli");
                    cliente.Email = resultado.GetString("email_cli");
                    cliente.CPF = resultado.GetString("cpf_cli");
                    cliente.Numero = resultado.GetString("numero_cli");
                    cliente.Cidade = resultado.GetString("cidade_cli");
                    cliente.Endereco = resultado.GetString("endereco_cli");
                }

                return cliente;

            }catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Insert(Cliente t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO cliente (nome_cli, cpf_cli, numero_cli, email_cli, cidade_cli, endereco_cli) " +
                    "VALUES (@nome, @cpf, @numero, @email, @cidade, @endereco)";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@cpf", t.CPF);
                query.Parameters.AddWithValue("@numero", t.Numero);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@cidade", t.Cidade);
                query.Parameters.AddWithValue("@endereco", t.Endereco);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Erro ao realizar o cadastro");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<Cliente> List()
        {
            try
            {
                List<Cliente> list = new List<Cliente>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM cliente";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Cliente()
                    {
                        //Id = reader.GetInt32("id_cli"),
                        //Nome = DAOHelper.GetString(reader, "nome_cli"),
                        //Email = DAOHelper.GetString(reader, "email_cli"),
                        //CPF = DAOHelper.GetString(reader, "cpf_cli"),
                        //Numero = DAOHelper.GetString(reader, "numero_cli"),
                        //Cidade = DAOHelper.GetString(reader, "cidade_cli"),
                        //Endereco = DAOHelper.GetString(reader, "endereco_cli")
                                            
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

        public void Update(Cliente t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "UPDATE cliente SET nome_cli = @nome_cli, cpf_cli = @cpf_cli, numero_cli = @numero_cli, email_cli = @email_cli, cidade_cli = @cidade_cli, endereco_cli = @endereco_cli";
               
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@cpf", t.CPF);
                query.Parameters.AddWithValue("@numero", t.Numero);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@cidade", t.Cidade);
                query.Parameters.AddWithValue("@endereco", t.Endereco);
                    
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
