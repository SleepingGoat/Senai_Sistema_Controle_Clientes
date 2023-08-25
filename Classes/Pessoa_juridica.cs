using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Controle_Clientes.Classes
{
    public class Pessoa_juridica : Clientes
    {
        public string CNPJ {get; set;}
        public string IE {get; set;}

        public override void Pagar_imposto(float v){
            this.Valor = v;
            this.Imposto = this.Valor * 20/100;
            this.Total = this.Valor + this.Imposto;            
        }

    }
}