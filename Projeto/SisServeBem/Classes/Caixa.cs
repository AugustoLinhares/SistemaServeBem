using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class Caixa
    {
        public int Id { get; set; }
        public double SaldoInicial { get; set; }
        public double SladoFinal { get; set; }
        public int Numero { get; set; }
        public double TotalPagamentos { get; set; }
        public double TotalRecebimentos { get; set; }
    }
}
