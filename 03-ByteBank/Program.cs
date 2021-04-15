using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoLucas = new ContaCorrente();
            contaDoLucas.titular = "Lucas";
            contaDoLucas.agencia = 863;
            contaDoLucas.numero = 86522;

            ContaCorrente contaDoLucas2 = new ContaCorrente();
            contaDoLucas2.titular = "Lucas2";

            Console.WriteLine(contaDoLucas);
            Console.WriteLine(contaDoLucas2);


            Console.ReadLine();
        }
    }
}
