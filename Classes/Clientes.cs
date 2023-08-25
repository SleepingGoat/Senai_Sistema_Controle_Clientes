using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Controle_Clientes.Classes
{
    public class Clientes
    {
        public string Nome {get; set;}       
        public string Endereco {get; set;}
        public float Valor {get; protected set;}
        public float Imposto {get; protected set;}
        public float Total {get; protected set;}

        public virtual void Pagar_imposto(float v){
            this.Valor = v;
            this.Imposto = this.Valor * 10/100;
            this.Total = this.Valor + this.Imposto;
        }
    }
}