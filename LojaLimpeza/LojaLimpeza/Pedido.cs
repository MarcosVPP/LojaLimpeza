using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public float ValorDoPedido { get; set; }
        public IList<ItemPedido> ListaItemPedido = new List<ItemPedido>();

        public Pedido(int id, DateTime dataPedido, Cliente cliente)
        {
            this.CodigoPedido = id;
            this.Cliente = cliente;
            this.DataPedido = dataPedido;
            RetiraProdutoEstoque();
        }

        public void AdicionaItemPedido(ItemPedido item)
        {
            ListaItemPedido.Add(item);
            CalculoValorPedido(item);
        }

        public void RetiraProdutoEstoque()
        {
            foreach (var itemPedido in ListaItemPedido)
            {
                var validaEstoque = itemPedido.ValidaQuantidadeItemPedido();

                if (validaEstoque)
                {
                    itemPedido.QuantidadeItemPedido -= Produto.QuantidadeEstoque;
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

        public void CalculoValorPedido(ItemPedido item)
        {
            foreach (var itemDePedido in ListaItemPedido)
            {
                this.ValorDoPedido += item.ValorDoItem;
            }
        }
    }
}
