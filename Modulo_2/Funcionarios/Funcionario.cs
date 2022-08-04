namespace Modulo_2.Funcionarios
{
    public class Funcionario
    {
        public string nome;
        public string cpf;
        public double salario;

        public double getBonificacao()
        {
            return salario*0.1;
        }
    }
}