namespace Aula13Uber
{
    public class Usuario
    {
        private string login = "rafacs@gmail.com";
        private string senha = "123456789";
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set;}
        public string TokenDeLogin { get; set;}

        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha){
                TokenDeLogin = "ksisjdsksocihbkjalobicsxnmklawjhb";
                return true;
            }
            return false; 
        }
        public void Logout(){
            TokenDeLogin = "";
        }
    }
}