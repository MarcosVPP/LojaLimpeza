using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Categoria
    {
        public int CodigoCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public IList<Produto> ListaProduto = new List<Produto>();

        public Categoria(int id, string nome)
        {
            this.CodigoCategoria = id;
            this.NomeCategoria = nome;
        }
    }
}
