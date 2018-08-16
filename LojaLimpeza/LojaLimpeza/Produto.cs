using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Categoria { get; set; }
        public int DataFabricacao { get; set; }
        public int DataValidade { get; set; }
        public int quantidade { get; set; }
    }

}
