using System;
using Ex2.classes;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            produto1.Codigo = 1;
            produto1.Nome = "Coca Cola";
            produto1.Descricao = "Refrigerante de Cola";
            produto1.Estoque = 30;

            Console.WriteLine($"Produto 1 - Código {produto1.Codigo}, Nome {produto1.Nome}, Descrição {produto1.Descricao}, Estoque {produto1.Estoque}");

            Produto produto2 = new Produto(10);
            produto2.Nome = "Pepsi";

            Console.WriteLine($"Código inserido {produto2.Codigo}, Nome {produto2.Nome}"); 

            Produto produto3 = new Produto(1,"Traquinas", "Bolacha de chocolate", 1000);

            Console.WriteLine($"Código {produto3.Codigo}, Nome {produto3.Nome}, Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");
        }
    }
}
