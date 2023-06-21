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
            throw new NotImplementedException();
        }

        public Funcionario GetById(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(Funcionario t)
        {
            throw new NotImplementedException();
        }
    }
}
