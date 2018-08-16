using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Contato
    {
        public int CodigoContato { get; set; }
        public string NomeContato { get; set; }
        public string Email { get; set; }
        public List<Telefone> ListaTelefones = new List<Telefone>();

        public Contato(int id, string nomeContato, string email)
        {
            this.CodigoContato = id;
            this.NomeContato = nomeContato;
            this.Email = email;
        }
    }
}
