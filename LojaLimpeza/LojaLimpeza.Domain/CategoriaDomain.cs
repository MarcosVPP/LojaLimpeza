﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;


namespace LojaLimpeza.Domain
{
    public  class  CategoriaDomain 
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }

        public CategoriaDomain(int codigo, string nome) 
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
    }
}
