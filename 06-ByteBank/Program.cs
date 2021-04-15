using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();
            cliente.Nome = "Lucas";
            cliente.CPF = "222.222.222-22";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = 1000;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
