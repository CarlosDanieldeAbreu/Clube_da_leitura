using System;

namespace Club_do_livro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            while (true)
            {
                menu.ApresentarMenu();
                menu.VerificaOpcaoEscolhida();
                if (menu.opcao == "s" || menu.opcao == "S")
                    break;
            }
        }
    }
}
