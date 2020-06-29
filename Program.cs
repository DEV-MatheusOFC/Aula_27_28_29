using System;

namespace Aula_27_28_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Sasmsumg Galaxy A20";
            p1.Preco = 800f;

            p1.Cadastrar(p1);
        }
    }
}
