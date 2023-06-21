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
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
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
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<Cliente> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente t)
        {
            throw new NotImplementedException();
        }
    }
}
