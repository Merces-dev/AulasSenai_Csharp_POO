using System;

namespace Aula09Calculadora
{
    public class Calculadora
    {   
        public int n1{get; set;}
        public int n2{get; set;}
        public int operacao {get; set;}
        protected int resultado{get; set;}
        
        
        public int Soma(){ 
        resultado = n1 + n2;
            return  (resultado);
        }
        public int Subtracao(){ 
         resultado = n1 - n2 ;
            return resultado ;
        }
        public int Multiplicacao(){ 
        resultado = n1 * n2;
            return  (resultado);
         }
        public int Divisao(){ 
         resultado = n1 / n2;    
            return  (resultado);
         }
        public int MediaF(){
        resultado = (n1 + n2) / 2; 
        return resultado;
    }
    }
 }