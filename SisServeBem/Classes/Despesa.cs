using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisServeBem.Classes
{
    internal class Despesa
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Forma { get; set; }
    }
}
