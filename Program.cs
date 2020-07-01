using System;
using System.Collections.Generic;

namespace Aula_27_28_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Samsung Galaxy A20";
            p1.Preco = 800f;

            p1.Cadastrar(p1);

            List<Produto> lista = p1.Ler();
            
            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}
