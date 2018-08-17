using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Telefone
    {
        public int CodigoTelefone;
        public string NumTelefone;



        public class Telefones
        {
            public int CodigoTelefone { get; set; }
            public int Numero1 { get; set; }
            public int Numero2 { get; set; }
            public int Numero3 { get; set; }
        }
    }
}
