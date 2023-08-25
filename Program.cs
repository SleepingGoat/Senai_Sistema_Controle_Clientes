using System;
namespace Sistema_Controle_Clientes.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            float Val_pag;
                Console.WriteLine("Informe o Nome:");
                string var_nome = Console.ReadLine();
                Console.WriteLine("Informe o Endereço:");
                string var_endereco = Console.ReadLine();
                Console.WriteLine("Pessoa Física (1) ou Jurídica(2)?");
                string var_tipo = Console.ReadLine();

                if(var_tipo == "1")
                {
                    Pessoa_fisica pf = new Pessoa_fisica();
                    pf.Nome = var_nome;
                    pf.Endereco = var_endereco;
                    Console.WriteLine("Informe o CPF:");
                    pf.CPF = Console.ReadLine();
                    Console.WriteLine("Informe o RG:");
                    pf.RG = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra:");
                    Val_pag = float.Parse(Console.ReadLine());
                    pf.Pagar_imposto(Val_pag);

                    Console.WriteLine("Nome...........: " + pf.Nome);
                    Console.WriteLine("Endereço.......: " + pf.Endereco);
                    Console.WriteLine("CPF............: " + pf.CPF);
                    Console.WriteLine("RG.............: " + pf.RG);
                    Console.WriteLine("Valor da Compra: " + pf.Valor.ToString("C"));
                    Console.WriteLine("Imposto........: " + pf.Imposto.ToString("C"));
                    Console.WriteLine("Total a pagar..: " + pf.Total.ToString("C"));                    
                }
                if(var_tipo == "2")
                {
                    Pessoa_juridica pj = new Pessoa_juridica();
                    pj.Nome = var_nome;
                    pj.Endereco = var_endereco;
                    Console.WriteLine("Informe o CNPJ:");
                    pj.CNPJ = Console.ReadLine();
                    Console.WriteLine("Informe o IE:");
                    pj.IE = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra:");
                    Val_pag = float.Parse(Console.ReadLine());
                    pj.Pagar_imposto(Val_pag);

                    Console.WriteLine("Nome...........: " + pj.Nome);
                    Console.WriteLine("Endereço.......: " + pj.Endereco);
                    Console.WriteLine("CPF............: " + pj.CNPJ);
                    Console.WriteLine("RG.............: " + pj.IE);
                    Console.WriteLine("Valor da Compra: " + pj.Valor.ToString("C"));
                    Console.WriteLine("Imposto........: " + pj.Imposto.ToString("C"));
                    Console.WriteLine("Total a pagar..: " + pj.Total.ToString("C"));
                }

        }
    }
}