using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoSaqDepTransf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________Banco Virtual____________________________________\r\n");

            Console.WriteLine(">> Nova Conta Corrente - Fulando\r\n");

            ContaCorrente contaFulano = new ContaCorrente();
            contaFulano.titular = "Fulano";
            Console.WriteLine("O nome do titular é " + contaFulano.titular + ".");
            Console.WriteLine("O saldo inicial da conta é de R$ " + contaFulano.saldo + ".");

            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("\r\n>> Saque na conta do Fulano\r\n");

            bool resultadoSaque = contaFulano.Sacar(20);
            Console.WriteLine("O saldo após o saque de R$ 20, é de R$ " + contaFulano.saldo + ".");
            Console.WriteLine("O saldo é maior que o valor sacado: " + resultadoSaque + ".");


            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("\r\n>> Depósito na conta do Fulano\r\n");

            contaFulano.Depositar(1000);
            Console.WriteLine("O saldo após o depósito de R$ 1.000, é de R$ " + contaFulano.saldo + ".");


            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("\r\n>> Nova Conta Corrente - Beltrano\r\n");

            ContaCorrente contaBeltrano = new ContaCorrente();
            contaBeltrano.titular = "Beltrano";
            Console.WriteLine("O nome do titular é " + contaBeltrano.titular + ".");
            Console.WriteLine("O saldo inicial da conta é de R$ " + contaBeltrano.saldo + ".");


            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("\r\n>> Transferência - De Fulano para Beltrano\r\n");

            bool resultadoTransferencia = contaFulano.Transferir(400, contaBeltrano);
            Console.WriteLine("O saldo do Beltrano após receber a transferência de R$ 400, é de R$ " + contaBeltrano.saldo + ".");
            Console.WriteLine("O saldo do Fulano após a retirada de R$ 400, é de R$ " + contaFulano.saldo + ".");


            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("\r\n>> Transferência - De Beltrano para Fulano\r\n");

            contaBeltrano.Transferir(100, contaFulano);
            Console.WriteLine("O saldo do Beltrano após a retirada de R$ 100, é de R$ " + contaBeltrano.saldo + ".");
            Console.WriteLine("O saldo do Fulano após a transferência de R$ 100, é de R$ " + contaFulano.saldo + ".");

            Console.ReadLine();
        }
    }
}
