using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            
            bool resultadoDoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoDoSaque);
            
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Transferir(500, contaDaGabriela);
            Console.WriteLine(contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
