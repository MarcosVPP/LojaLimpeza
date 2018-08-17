using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class ItemPedido
    {
        private float valorDoItem;

        public int IdItemPedido { get; set; }
        public int QuantidadeItemPedido { get; set; }
        public float ValorDoItem { get { return this.valorDoItem; } }
        public Produto Produto { get; set; }

        public ItemPedido(int id, int quantidadeItemPedido, Produto produto)
        {
            this.IdItemPedido = id;
            this.Produto = produto;
            this.QuantidadeItemPedido = quantidadeItemPedido;
            Validacoes();
        }

        public void Validacoes()
        {
            ValidaQuantidadeItemDePedido();
            CalculaValorDoItem();
            RemoveEstoque();
        }

        public void RemoveEstoque()
        {
            Produto.RemoverEstoque(QuantidadeItemPedido);
        }

        public bool ValidaQuantidadeItemDePedido()
        {
            if (this.QuantidadeItemPedido > 0 && this.QuantidadeItemPedido < this.Produto.QuantidadeEmEstoque)
            {
                return true;
            }
            else
            {
                throw new Exception("A Quantidade deve ser maior que zero");
            }
        }

        public void CalculaValorDoItem()
        {
            var validaPrecoProduto = Produto.ValidaPrecoProduto();

            if (validaPrecoProduto)
            {
                this.valorDoItem = this.Produto.Preco * this.QuantidadeItemPedido;
            }
            else
            {
                throw new Exception("O preço do produto é inválido");
            }
        }
    }
}
