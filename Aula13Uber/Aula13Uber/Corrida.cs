namespace Aula13Uber
{
    public class Corrida : Passageiro
    {
        private string localInicio { get; set; }
        public string localChegada { get; set; }
        private string motorista { get; set; }
        private string passageiro { get; set; }
        private string statusCorrida { get; set; }

        public string Cancelar(){ 
        return "Corrida sendo cancelada...";
        }
    }
}