using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetoWhatsapp
{
    public class Agenda : IAgenda
    {
        public List<Contato> Contatos;
        protected const string PATH = "Database/agenda.csv";
        public Agenda()
        {
        }
        /// <summary>
        /// Método Construtor
        /// </summary>
        /// <param name="_contatos"></param>
        public Agenda(List<Contato> _contatos){
            this.Contatos = _contatos;
            
        }
        /// <summary>
        /// Prepara a linha para o CSV
        /// </summary>
        /// <param name="c"></param>
        /// <returns>Retorna a linha do CSV</returns>
        private string PrepararLinha(Contato c)
        {
            return $"Contato = {c.Nome};Telefone = {c.Telefone}";
        }
        /// <summary>
        /// Separa os dados em colunas no CSV
        /// </summary>
        /// <param name="_coluna"></param>
        /// <returns>Retorna o valor após o " = "</returns>
        private string SepararDados(string _coluna)
        {
            return _coluna.Split("=")[1];
        }
        /// <summary>
        /// Cadastra o Contato no CSV
        /// </summary>
        /// <param name="cont"></param>
        public void Cadastrar(Contato cont)
        {
        var linha = new string[] { PrepararLinha(cont) };
        File.AppendAllLines(PATH, linha);
        }
        /// <summary>
        /// Exclui um contato no CSV
        /// </summary>
        /// <param name="cont"></param>
        public void Excluir(Contato cont)
        {
        List<string> linhas = new List<string>();
        using (StreamReader arquivo = new StreamReader(PATH)){
            string linha;
            while ((linha = arquivo.ReadLine())!= null){
                linhas.Add(linha);
            }
        }
        {
            linhas.RemoveAll(l => l.Contains(cont.Nome));
            {
            using (StreamWriter output = new StreamWriter(PATH))
            {
                foreach (string ln in linhas)
                {
                    output.Write(ln + "\n");
                }
            }
        }
        }
        }
        /// <summary>
        /// Lê a linha do CSV
        /// </summary>
        /// <returns>Retorna lista de contatos</returns>
        public List<Contato> Listar()
        {
        List<Contato> contatos = new List<Contato>();
        string[] linhas = File.ReadAllLines(PATH);
        Contato c = new Contato();
        foreach (string line in linhas)
        {
            string[] dados = line.Split(";");
            c.Nome = SepararDados(dados[0]);
            c.Telefone = SepararDados(dados[1]);
            contatos.Add(c);
        }
        contatos = contatos.OrderBy(x => x.Nome).ToList();
        return contatos;
        }
        

    }
}