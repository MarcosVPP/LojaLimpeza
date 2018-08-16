using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public float ValorDoPedido { get; set; }
        public IList<ItemPedido> ListaItemPedido = new List<ItemPedido>();

        public Pedido(int id, DateTime dataDoPedido, Cliente cliente)
        {
            this.IdPedido = id;
            this.Cliente = cliente;
            this.DataPedido = dataDoPedido;
            RetiraProdutoDoEstoque();
        }

        public void AdicionaItemPedido(ItemPedido item)
        {
            ListaItemPedido.Add(item);
            CalculoValorDoPedido(item);
        }

        public void RetiraProdutoDoEstoque()
        {
            foreach (var itemPedido in ListaItemPedido)
            {
                var validaEstoque = itemPedido.ValidaQuantidadeItemDePedido();

                if (validaEstoque)
                {
                    itemPedido.QuantidadeItemPedido -= Produto.QuantidadeEmEstoque;
                }
            }
        }

        public void RemoveProduto()
        {
            foreach (var itemPedido in ListaItemPedido)
            {
                ListaItemPedido.Remove(itemPedido);
            }
        }

        public void CalculoValorDoPedido(ItemPedido item)
        {
            foreach (var itemDePedido in ListaItemPedido)
            {
                this.ValorDoPedido += item.ValorDoItem;
            }
        }
    }
}
