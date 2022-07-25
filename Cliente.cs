namespace Aprendendo_CSharp
{
    public class Cliente
    {
        public string nome {get; set;};
        public string CPF { get; set;} 
        public string Profissao {get; set;} 
    }
    public class Endereco
    {
        
        public string rua; 
        public string bairro;
        public string cidade;
        public string cep;
        public int numero;
    }
}