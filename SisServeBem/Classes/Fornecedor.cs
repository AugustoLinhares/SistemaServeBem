using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    class Fornecedor
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
    }
}
