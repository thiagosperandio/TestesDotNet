﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjetoFacade
{
    public class Cliente
    {
        public string Nome { get; set; }
        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
