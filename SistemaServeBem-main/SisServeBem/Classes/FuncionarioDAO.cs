using MySql.Data.MySqlClient;
using SisServeBem.ConexaoBanco;
using SisServeBem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class FuncionarioDAO : IDAO<Funcionario>
    {
        private Conexao conexao;
        public FuncionarioDAO()
        {
            conexao = new Conexao();
        }
        public void Delete(Funcionario t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "DELETE FROM funcionario WHERE id_fun = @id";

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

        public Funcionario GetById(int id)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "SELECT * FROM funcionario WHERE id_cli = @id";

                query.Parameters.AddWithValue("id", id);

                var resultado = query.ExecuteReader();

                var funcionario = new Funcionario();

                while (resultado.Read())
                {
                    funcionario.Id = resultado.GetInt32("id_cli");
                    funcionario.Nome = resultado.GetString("nome_cli");
                    funcionario.CPF = resultado.GetString("cpf_cli");
                    funcionario.Funcao = resultado.GetString("funcao_cli");
                    funcionario.Cidade = resultado.GetString("cidade_cli");
                    funcionario.UF = resultado.GetString("uf_cli");
                }

                return funcionario;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Funcionario t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO Funcionario (nome_fun, cpf_fun, funcao_fun, cidade_fun, uf_fun) " +
                    "VALUES (@nome, @cpf, @funcao, @cidade, @uf)";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@cpf", t.CPF);
                query.Parameters.AddWithValue("@funcao", t.Funcao);
                query.Parameters.AddWithValue("@cidade", t.Cidade);
                query.Parameters.AddWithValue("@uf", t.UF);

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

        public List<Funcionario> List()
        {
            try
            {
                List<Funcionario> list = new List<Funcionario>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM funcionario";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Funcionario()
                    {
                        //Id = reader.GetInt32("id_fun"),
                        //Nome = DAOHelper.GetString(reader, "nome_fun"),
                        //CPF = DAOHelper.GetString(reader, "cpf_fun"),
                        //Funcao = DAOHelper.GetString(reader, "funcao_fun"),
                        //Cidade = DAOHelper.GetString(reader, "cidade_fun"),
                        //UF = DAOHelper.GetString(reader, "uf_fun")

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

        public void Update(Funcionario t)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "UPDATE funcionario SET nome_fun = @nome_fun, cpf_fun = @cpf_fun, funcao_fun = @funcao_fun, cidade_fun = @cidade_fun, uf_fun = @uf_fun";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@cpf", t.CPF);
                query.Parameters.AddWithValue("@funcao", t.Funcao);
                query.Parameters.AddWithValue("@cidade", t.Cidade);
                query.Parameters.AddWithValue("@UF", t.UF);

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
