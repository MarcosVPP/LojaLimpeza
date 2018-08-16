using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Cliente
    {
        private int limiteCredito;

        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string Filiacao { get; set; }
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
        public StatusCliente StatusCliente { get; set; }
        public int LimiteCredito { get { return this.limiteCredito; } }
        public IList<Pedido> ListaPedido = new List<Pedido>();

        public Cliente(int id, string nomeCliente, string cpf, string filiacao, Contato contato, Endereco endereco, int limiteCredito)
        {
            this.CodigoCliente = id;
            this.NomeCliente = nomeCliente;
            this.CPF = cpf;
            this.Filiacao = filiacao;
            this.Contato = contato;
            this.Endereco = endereco;
            this.limiteCredito = limiteCredito;
        }
    }
}
