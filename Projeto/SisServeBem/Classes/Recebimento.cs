using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class Recebimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }
        public string Forma { get; set; }
        public Venda Venda { get; set; }
        public Caixa Caixa { get; set; }
    }
}
