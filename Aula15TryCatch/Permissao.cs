using System;
namespace Aula15TryCatch
{
    public class Permissao
    {
        public bool Permitir{get; set;}
        public void Autorizar(){
            System.Console.WriteLine("Deseja permitir acesso? True or False");
            try{
                Permitir = Boolean.Parse(Console.ReadLine());
            }catch(Exception){
                System.Console.WriteLine("Erro na aplicação - Dados Inválidos ");
            }
        }
    }
}