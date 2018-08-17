using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Fornecedor
    {
        public int CodigoFornecedor { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }

        public Fornecedor(int id, string cnpj, string nomeFantasia, string razaoSocial)
        {
            this.CodigoFornecedor = id;
            this.CNPJ = cnpj;
            this.NomeFantasia = nomeFantasia;
            this.RazaoSocial = razaoSocial;
        }
    }
}
