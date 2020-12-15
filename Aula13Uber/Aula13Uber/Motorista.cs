namespace Aula13Uber
{
    public class Motorista: Usuario
    {
        private string carro { get; set; }

        private string placa { get; set; }

        public bool AceitarPassageiro(){
        return true;
        }
        public bool ReceberPagamento(){
            return true;
        }
        

    }
}