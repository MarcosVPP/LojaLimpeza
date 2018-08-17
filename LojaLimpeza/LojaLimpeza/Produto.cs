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
        public int Quantidade { get; set; }
        public int QuantidadeEmEstoque { get; internal set; }
        public int Preco { get; internal set; }

        internal void RemoverEstoque(int quantidadeItemPedido)
        {
            throw new NotImplementedException();
        }

        internal object ValidaPrecoProduto()
        {
            throw new NotImplementedException();
        }
    }

}
