using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public bool BtRecebeEmail { get; set; }
        public bool BtRecebeSMS { get; set; }
    }
}
