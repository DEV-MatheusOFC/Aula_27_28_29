using System;
using System.Collections.Generic;
using System.IO;
namespace Aula_27_28_29
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto(){
            // Cria o arquivo caso não exista.
            if(!File.Exists(PATH)){
                Directory.CreateDirectory("Database");
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Produto prod)
        {
            var linha = new string[] {PrepararLinha(prod)};
            File.AppendAllLines(PATH, linha);
        }

        public List<Produto> Ler()
        {
            List<Produto> prod = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                string[] dado = linha.Split(";");

                Produto p = new Produto();
                p.Codigo = Int32.Parse( dado[0].Split("=")[1] );
                p.Nome = dado[1].Split("=")[1];
                p.Preco = float.Parse( dado[2].Split("=")[1] );

                prod.Add(p);
            }

            return prod;
        }

        public string Separar(string dado)
        {
            return dado.Split("=")[1];
        }

        private string PrepararLinha(Produto p)
        {
            return $"Codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
        }
    }
}