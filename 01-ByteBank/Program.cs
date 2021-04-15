using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //string titular = "Gabriela";
            //int numeroAgencia = 863;
            //int numero = 863146;
            //double saldo = 100;

            //string titular2 = "Bruno";
            //int numeroAgencia2 = 864;
            //int numero2 = 864146;
            //double saldo2 = 50;

            ContaCorrente contaDoLucas = new ContaCorrente();
            contaDoLucas.titular = "Lucas Ferrari";
            contaDoLucas.agencia = 863;
            contaDoLucas.numero = 863452;
            contaDoLucas.saldo = 100;

            Console.WriteLine(contaDoLucas.titular);
            Console.WriteLine(contaDoLucas.agencia);
            Console.WriteLine(contaDoLucas.numero);
            Console.WriteLine(contaDoLucas.saldo);

            Console.ReadLine();
        }
    }
}
