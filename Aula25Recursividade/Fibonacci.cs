using System;
namespace Aula25Recursividade
{
    public class Fibonacci
    {
        public void GerarSequenciaFibonacci(int num1, int num2, int vezes) { 
            if(vezes > 0){
            System.Console.Write(num1+", ");
            GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }
    
         }
        public int GerarFatorial(int num) {
        if(num == 1){
            return 1;
        }else{
            return num * GerarFatorial(num - 1);
        } 
        }
    }
}