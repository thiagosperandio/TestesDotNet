﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjetoFacade
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine("Verificando SERASA do cliente " + cliente.Nome);
            return false;
        }
    }
}
