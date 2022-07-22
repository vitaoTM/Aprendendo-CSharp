using System;

namespace Aprendendo_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular = "Bruce Waine";
            string conta = "BAT";
            int agencia = 42;
            double saldo = 100000.99;

            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Conta: {conta}");
            Console.WriteLine($"Agencia: {agencia}");
            Console.WriteLine($"Saldo: {saldo}");

            Console.ReadKey();
        }
    }
}
