﻿using System;

namespace Aprendendo_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using ContaCorrente;
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Bruce Waine";
            conta1.conta = "12345-6";
            conta1.nome_agencia = "BatBank";
            conta1.numero_agencia = 42;
            conta1.saldo = 100000000000.99;


            Console.WriteLine($"Titular: {conta1.titular}");
            Console.WriteLine($"Conta: {conta1.conta}");
            Console.WriteLine($"Agencia: {conta1.numero_agencia}");
            Console.WriteLine($"Saldo: {conta1.nome_agencia}");
            Console.WriteLine($"Saldo: {conta1.saldo}");

            Console.ReadKey();
        }
    }
}
