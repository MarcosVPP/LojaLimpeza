using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLimpeza
{
    public class StatusCliente
    {
        public int CodigoStatus { get; set; }
        public IList<Cliente> ListaCliente = new List<Cliente>();
        public string NomeStatus { get; set; }

        public void VerificarStatusCliente(Cliente cliente)
        {
            foreach (var listaCliente in ListaCliente)
            {
                if (cliente.LimiteCredito < 1000)
                {
                    this.CodigoStatus = 1;
                }
                else if (cliente.LimiteCredito <= 3000)
                {
                    this.CodigoStatus = 2;
                }
                else if (cliente.LimiteCredito > 3000)
                {
                    this.CodigoStatus = 3;
                }
                else
                {
                    throw new Exception("Status do Cliente inváido !!!");
                }
            }
        }
    }
}
