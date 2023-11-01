using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class Compra
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public int Parcelas { get; set; }
        public Funcionario Funcionario { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Despesa Despesa { get; set; }
    }
}
