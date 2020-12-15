namespace Aula13Uber
{
    public class Passageiro: Usuario
    {
        public void SolicitarMotorista(){ 
        System.Console.WriteLine("Procurando Motorista...");
        System.Threading.Thread.Sleep(1200);
        System.Console.Clear();
        System.Console.WriteLine("Motorista encontrado");
        }
        public bool Pagar(string statusCorrida){
            if(statusCorrida == "finalizada"||statusCorrida == "Finalizada"){
                return true;
            }
                return false;
        }
    }
}   