using System;
using System.Collections.Generic;
using Aula34MVCConsole.Models;
using Aula34MVCConsole.Views;

namespace Aula34MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView  = new ProdutoView();        
        public void Listar() {
            produtoView.MostrarNoConsole(produtoModel.Ler());
            
        }
        public void Filtrar( string _preco) {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(_preco));
            Console.ForegroundColor = ConsoleColor.Blue;
            produtoView.MostrarNoConsole(lista);
            
        }
    }
}