namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        public string carro { get; set; }
        public string placa { get; set; }

        public string aceitarPassageiro(string nome){
            return "Passageiro aceito";
        }
        public bool receberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizada"){
                return true;
            }else{
                return false;
            }
        }



    }
}