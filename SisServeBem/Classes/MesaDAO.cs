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
    internal class MesaDAO : IDAO<Mesa>
    {
        private Conexao conexao;
        public MesaDAO()
        {
            conexao = new Conexao();
        }
        public void Delete(Mesa t)
        {
            throw new NotImplementedException();
        }

        public Mesa GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Mesa t)
        {
            throw new NotImplementedException();
        }

        public List<Mesa> List()
        {
            try
            {
                List<Mesa> list = new List<Mesa>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM Mesa";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Mesa()
                    {
                        Id = reader.GetInt32("id_mes"),
                        Status = DAOHelper.GetString(reader, "status_mes"),
                        Cadeiras = DAOHelper.GetString(reader, "cadeiras_mes"),
                        Numero = reader.GetInt32("numero_mes")
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

        public List<Mesa> ListVazia()
        {
            try
            {
                List<Mesa> list = new List<Mesa>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM Mesa where status_mes = 'Ocupada'";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Mesa()
                    {
                        Id = reader.GetInt32("id_mes"),
                        Status = DAOHelper.GetString(reader, "status_mes"),
                        Cadeiras = DAOHelper.GetString(reader, "cadeiras_mes"),
                        Numero = reader.GetInt32("numero_mes")
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

        public void Update(Mesa t)
        {
            throw new NotImplementedException();
        }
    }
}
