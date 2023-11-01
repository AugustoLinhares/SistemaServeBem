using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCusto { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public Estoque Estoque { get; set; }
    }
}
