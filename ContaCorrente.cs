using Aprendendo_CSharp;
using Aprendendo_CSharp.Titular;

namespace Aprendendo_CSharp
{
    public class ContaCorrente
    {

        public ContaCorrente(Cliente titular, string nome_Agencia) 
        {
            this.Titular = titular;
                this.Nome_Agencia = nome_Agencia;
               
        }
        public ContaCorrente(Cliente titular, string nome_Agencia) 
        {
            this.Titular = titular;
                this.Nome_Agencia = nome_Agencia;
               
        }
        public ContaCorrente(Cliente titular, string nome_Agencia) 
        {
            this.Titular = titular;
                this.Nome_Agencia = nome_Agencia;
               
        }
        public ContaCorrente(Cliente titular, string nome_Agencia) 
        {
            this.Titular = titular;
                this.Nome_Agencia = nome_Agencia;
               
        }
        public ContaCorrente(Cliente titular, string nome_Agencia) 
        {
            this.Titular = titular;
                this.Nome_Agencia = nome_Agencia;
               
        }
        public ContaCorrente(Cliente titular, string nome_Agencia) 
        {
            this.Titular = titular;
                this.Nome_Agencia = nome_Agencia;
               
        }
                                                        public Cliente Titular { get; set; }
        public string Nome_Agencia { get; set; }
        public int Numero_agencia
        {
            get;

            set;
            

        }
        public string Conta
        {
            get;
            set;
        }

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

       
    }
}