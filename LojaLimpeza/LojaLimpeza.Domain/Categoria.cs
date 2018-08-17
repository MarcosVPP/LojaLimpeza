using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza.Domain
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Categoria(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
    }
}
