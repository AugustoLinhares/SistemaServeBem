using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class Prato
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Peso { get; set; }
        public string SelfService { get; set; }
        public string Nome { get; set; }
        public Venda Venda { get; set; }
        public Pedido Pedido { get; set; }
    }
}
