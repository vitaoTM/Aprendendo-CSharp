namespace Aprendendo_CSharp
{
    public class ContaCorrente
    {
        public publicstring titular;
        public string conta;
        public string nome_agencia;
        public int numero_agencia;
        public double saldo;
        public bool verificador;

    }

    public bool Sacar(double valor) 
    {
        if(saldo < valor)
        {
            return false;
        }
        if(valor < 0)
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