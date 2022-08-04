using System;

namespace Modulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario joao = new Funcionario();
            joao.nome = "Joao";
            joao.cpf = "65435691517";
            joao.salario = 2000; 

            Console.WriteLine($"Bonificacao: {joao.getBonificacao()}");

        }
    }
}
