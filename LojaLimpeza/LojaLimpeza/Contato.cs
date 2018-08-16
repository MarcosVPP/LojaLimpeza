using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class Contato
    {
        public int IdContato { get; set; }
        public string NomeContato { get; set; }
        public string Email { get; set; }
        public List<Telefone> ListaDeTelefones = new List<Telefone>();

        public Contato(int id, string nomeDoContato, string email)
        {
            this.IdContato = id;
            this.NomeContato = nomeDoContato;
            this.Email = email;
        }
    }
}
