namespace Aula13Uber
{
    public class Cartao
    {
        public string numero { get; set; }
        public string titular { get; set; }
        public int cvv {get; set; }

        public string Cadastrar(){
            return $"Cartão de número {numero}, titular {titular} e CVV {cvv} cadastrado";
        }

        public void Excluir(){
            
        }
    }
}