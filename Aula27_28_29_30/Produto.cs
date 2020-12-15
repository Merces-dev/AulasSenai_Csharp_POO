using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula27_28_29_30
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public const string PATH = "Database/produto.csv";

        /// <summary>
        /// Cria A pasta ou diretorio, caso não existam
        /// </summary>
        public Produto()
        {
            string pasta = PATH.Split("/")[0];
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
                if (!File.Exists(PATH))
                {
                    File.Create(PATH).Close();
                }
            }
        }
        //1;celular;600
        /// <summary>
        /// Prepara a linha do arquivo csv
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Retorna a linha da forma que será escrita no csv</returns>
        private string PrepararLinha(Produto p)
        {
            return $"codigo = {p.Codigo};nome = {p.Nome};preco = R${p.Preco}";
        }

        /// <summary>
        ///  Cadastra produto
        /// </summary>
        /// <param name="prod"></param>
        public void Cadastrar(Produto prod)
        {
            var linha = new string[] { PrepararLinha(prod) };

            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Lê o csv
        /// </summary>
        /// <returns>retorna lista de produtos</returns>
        public List<Produto> Ler()
        {
            //lista que servirá de retorno
            List<Produto> produtos = new List<Produto>();

            //lemos o arquivo e o transformamos  em um array de linhas
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                //separamos os  dados de cada linha com Split
                string[] dados = linha.Split(";");
                //Criamos instâncias de produtos para serem colocados na lista
                Produto p = new Produto();
                p.Codigo = Int32.Parse(SepararDados(dados[0]));
                p.Nome = SepararDados(dados[1]);
                p.Preco = float.Parse(SepararDados(dados[2]));

                //Adicionamos o produto da lista antes de retorná-lo
                produtos.Add(p);
            }
            produtos = produtos.OrderBy(y => y.Nome).ToList();
            return produtos;
        }
        /// <summary>
        /// Filtra dentro do .csv
        /// </summary>
        /// <param name="_nome"></param>
        /// <returns>retorna o nome dos produtos</returns>
        public List<Produto> Filtrar(string _nome)
        {
            return Ler().FindAll(x => x.Nome == _nome);
        }

        /// <summary>
        /// Separa os dados em colunas
        /// </summary>
        /// <param name="_coluna"></param>
        /// <returns>Retorna o valor pedido, por coluna</returns>
        private string SepararDados(string _coluna)
        {
            //   0      1 (por isso o índice 1)
            // PRECO = 800
            return _coluna.Split("=")[1];
        }
        /// <summary>
        /// Reescreve o CSV
        /// </summary>
        /// <param name="lines">Lista de linhas</param>
        private void ReescreverCSV(List<string> lines)
        {
            //Reescrevemos nosso .csv do zero
            using (StreamWriter output = new StreamWriter(PATH))
            {
                foreach (string ln in lines)
                {
                    output.Write(ln + "\n");
                }
            }
        }

        /// <summary>
        /// remove uma ou mais linhas que contenham o termo
        /// </summary>
        /// <param name="_termo"></param>
        public void Remover(string _termo)
        {
            //Criamos uma lista que servirá como uma especie de backup de linhas do csv
            List<string> linhas = new List<string>();
            //Utilizamos a biblioteca StreamReader para ler nosso .csv
            using (StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
                {
                    //Removemos as linhas que tiverem o _termo como argumento
                    linhas.RemoveAll(l => l.Contains(_termo));

                    ReescreverCSV(linhas);
                }
            }
        }
        public void Alterar(Produto produtoAlterado)
        {
            //Criamos uma lista que servirá como uma especie de backup de linhas do csv
            List<string> linhas = new List<string>();
            //Utilizamos a biblioteca StreamReader para ler nosso .csv
            using (StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
                {
                    linhas.RemoveAll(z => z.Split(";")[0].Split("=")[1] == produtoAlterado.Codigo.ToString());
                    linhas.Add(PrepararLinha(produtoAlterado));
                    ReescreverCSV(linhas);         

                }


            }
        }
    }
}