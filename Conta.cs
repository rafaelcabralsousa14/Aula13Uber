namespace Aula13Uber
{
    public class Conta
    {
        public string agencia { get; set; }
        public string conta { get; set; }

        public string Cadastrar(){
            return $"Conta {conta} da agência {agencia} adicionada";
        }
        public void Excluir(){
            
        }
    }
}