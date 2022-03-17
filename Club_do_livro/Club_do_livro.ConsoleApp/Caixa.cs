using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_do_livro.ConsoleApp
{
    public class Caixa
    {
        public string cor;
        public string etiqueta;
        public int numero;

        #region codigo antes do Tiago
        //public void CadastrarCaixa()
        //{
        //    int i = 0;

        //    Menu menu = new Menu();
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("===Cadastrar=caixa===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");

        //    while (true)
        //    {
        //        menu.ApresentarMenuInserirSair();
        //        string opcao = Console.ReadLine();
        //        Console.WriteLine("");

        //        if (opcao == "1")
        //        {
        //            Console.WriteLine("Cor: ");
        //            string corDaCaixa = Console.ReadLine();
        //            cor[i] = corDaCaixa.ToString();

        //            Console.WriteLine("Etiqueta: ");
        //            string etiquetaCaixa = Console.ReadLine();
        //            etiqueta[i] = etiquetaCaixa.ToString();

        //            Console.WriteLine("Número: ");
        //            string numeroCaixa = Console.ReadLine();
        //            numero[i] = Convert.ToInt32(numeroCaixa);

        //            i++;
        //        }
        //        else if(opcao == "2")
        //        {
        //            break;
        //        }
        //    }
        //}

        //public void VisualizarCaixa()
        //{
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("===Visualizar=caixa===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");

        //    for (int i = 0; i < cor.Length; i++)
        //    {
        //        if (cor[i] != null)
        //        {
        //            Console.WriteLine("Cor: {0}, Etiqueta: {1}, Número: {2}", cor[i], etiqueta[i], numero[i]);
        //        }
        //        else
        //        {
        //            notificar.ApresentarMensagem("Nenhum caixa cadastrado!!!", ConsoleColor.Yellow);
        //            break;
        //        }
        //    }
        //}
        #endregion
    }
}
