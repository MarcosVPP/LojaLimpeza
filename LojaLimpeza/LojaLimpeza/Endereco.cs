using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        public Endereco(int id, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            this.IdEndereco = id;
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.UF = uf;
            this.CEP = cep;
        }
    }
}

// { return }
