﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Produto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get { return this.Fornecedor; } }
        public float Preco { get; set; }

        public Produto(int id, string nome, DateTime dataFabricacao, DateTime dataValidade, int quantidade, Categoria categoria, float preco)
        {
            this.CodigoProduto = id;
            this.NomeProduto = nome;
            this.DataFabricacao = dataFabricacao;
            this.DataValidade = dataValidade;
            this.QuantidadeEstoque = quantidade;
            this.Categoria = categoria;
            this.Preco = preco;
            ValidaPrecoProduto();
            ValidaEstoque(quantidade);
        }

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

        public bool ValidaPrecoProduto()
        {
            if (this.Preco > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("Preço do produto deve ser maior que zero !!!");
            }
        }
        public bool ValidaEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("Quantidade deve ter o valor maior que zero !!!");
            }
        }
        public void AdicionaEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.QuantidadeEstoque += quantidade;
            }
            else
            {
                throw new Exception("Quantidade á ser adicionada deve ser maior que zero !!!");
            }
        }
        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.QuantidadeEstoque -= quantidade;
            }
            else
            {
                throw new Exception("Quantidade á ser adicionada deve ser maior que zero !!!");
            }

            if (this.Valor <= 0)
                return false;
            else
                return true;
        }
    }

}
