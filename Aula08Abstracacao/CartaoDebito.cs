namespace Aula08Abstracacao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }
        public string Transferir(){
            return "Transferencia efetuada";
                }
         public string PagarTitulo(){
            return "Titulo pago";
                }
}
}