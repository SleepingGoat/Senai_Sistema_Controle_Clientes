using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Controle_Clientes.Classes
{
    public class Pessoa_fisica : Clientes
    {
        public string CPF {get; set;}
        public string RG {get; set;}
    }
}