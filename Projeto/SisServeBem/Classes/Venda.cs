using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Cliente Cliente { get; set; }
        public Pedido Pedido { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
