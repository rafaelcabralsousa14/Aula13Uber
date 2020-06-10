using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            System.Console.WriteLine("Digite seu login");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();

            System.Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            
            user.Login(login,senha);
            
            System.Console.WriteLine("Digite sua localização atual");
            string localizacaoAtual = Console.ReadLine();            

            if(user.TokenDeLogin != "" && user.TokenDeLogin != null){
                System.Console.WriteLine("Login efetuado com sucesso");
            }else{
                System.Console.WriteLine("Usuário deslogado");
            }

            System.Console.WriteLine("Você é um passageiro ou um motorista?");
            string usuario = Console.ReadLine();
            
            Motorista motorista = new Motorista();
            Passageiro passageiro = new Passageiro();
            System.Console.WriteLine(passageiro.ProcurarMotorista());                
            passageiro.Nome = "Rafael";
            motorista.Nome = "Lucas";
            System.Console.WriteLine(motorista.aceitarPassageiro("Rafael"));

            Corrida corrida = new Corrida();
            System.Console.WriteLine("Corrida iniciada");
            System.Console.WriteLine("Para onde você quer ir?");
            string resposta = Console.ReadLine();
            corrida.localInicio = localizacaoAtual;
            corrida.localChegada = resposta;
            System.Console.WriteLine($"Corrida programada de {corrida.localInicio} para {corrida.localChegada}! É só esperar o motorista chegar!"
            );
            corrida.passageiro = passageiro.Nome;
            corrida.motorista = motorista.Nome;
            corrida.statusCorrida = "Corrida em andamento";
            System.Console.WriteLine("Quer cancelar a corrida? [Responder com 'true' ou 'false']");
            bool cancelamento = bool.Parse(Console.ReadLine());
            if(cancelamento == true){
                System.Console.WriteLine(corrida.Cancelar());
            }
            corrida.statusCorrida = "Corrida finalizada";

            Cartao cartão = new Cartao();
            System.Console.WriteLine("Antes de ir para o pagamento, deseja adicionar um novo cartão? [Responda com 'true' ou 'false']");
            bool adicionarCartao = bool.Parse(Console.ReadLine());
            if(adicionarCartao == true){
                System.Console.WriteLine("Digite o número do cartão:");
                cartão.numero = Console.ReadLine();
                System.Console.WriteLine("Digite o titular do cartão:");
                cartão.titular = Console.ReadLine();
                System.Console.WriteLine("Digite o CVV do cartão:");
                cartão.cvv = Int32.Parse(Console.ReadLine());
                cartão.Cadastrar();
            }
            System.Console.WriteLine("Digite o número do cartão que usará para o pagamento:");
            cartão.numero = Console.ReadLine();
            
            Pagamento pagamento = new Pagamento();
            passageiro.Pagar("Finalizada");
            pagamento.valor = "R$20,00";
            System.Console.WriteLine("Digite a data do pagamento"); 
            string dataDigitada = Console.ReadLine();
            pagamento.data = dataDigitada;
            motorista.receberPagamento("Finalizada");
            System.Console.WriteLine($"Pagamento finalizado, na data {dataDigitada}, com o cartão {cartão.numero} e no valor de {pagamento.valor}");

            System.Console.WriteLine("Obrigado por usar nossos serviços!");
        }
    }
}
