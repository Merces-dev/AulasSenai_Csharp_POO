﻿using System;
using Aula34MVCConsole.Controllers;

namespace Aula34MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Listar();
            produto.Filtrar("7500");
        }
    }
}
