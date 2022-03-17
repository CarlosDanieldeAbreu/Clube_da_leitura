using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_do_livro.ConsoleApp
{
    public class Revista
    {
        public string tipoDaRevista;
        public int numeroDaEdicao;
        public int anoDaRevista;
        public string tipoDaCaixa;
        public Caixa caixas;

        #region codigo antes do Tiago
        //public void CadastrarRevista()
        //{
        //    int i = 0;
        //    Notificar notificar = new Notificar();
        //    Menu menu = new Menu();
        //    notificar.ApresentarMensagemSemReadLine("===Cadastrar=revista===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");

        //    while (true)
        //    {
        //        menu.ApresentarMenuInserirSair();
        //        string opcao = Console.ReadLine();
        //        Console.WriteLine("");

        //        if (opcao == "1")
        //        {
        //            Console.WriteLine("Tipo da revista: ");
        //            string tipoRevista = Console.ReadLine();
        //            tipoDaRevista[i] = tipoRevista.ToString();

        //            Console.WriteLine("Edição: ");
        //            string edicao = Console.ReadLine();
        //            numeroDaEdicao[i] = Convert.ToInt32(edicao);

        //            Console.WriteLine("Ano: ");
        //            string ano = Console.ReadLine();
        //            anoDaRevista[i] = Convert.ToInt32(ano);

        //            while (true)
        //            {
        //                Console.WriteLine("Caixa: ");
        //                string caixa = Console.ReadLine();
        //                tipoDaCaixa[i] = caixa.ToString();

        //                //if (tipoDaCaixa == caixas[i].etiqueta)
        //                //{
        //                //    break;
        //                //}
        //                //else
        //                //{
        //                //    notificar.ApresentarMensagem("Essa caixa não existe", ConsoleColor.Yellow);
        //                //    Console.ReadLine();
        //                //}
        //            }


        //            i++;
        //        }else if (opcao == "2")
        //        {
        //            break;
        //        }
        //    }
        //}
        //public void VisualizarRevistas()
        //{
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("===Visualizar=revista===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");
        //    for (int i = 0; i < tipoDaRevista.Length; i++)
        //    {
        //        if(tipoDaRevista[i] != null)
        //        {
        //            Console.WriteLine("Tipo da revista: {0}, Edição: {1}, Ano: {2}, Caixa da revista: {3}", tipoDaCaixa[i], numeroDaEdicao[i], anoDaRevista[i], caixas[i].etiqueta);
        //            Console.WriteLine("Cor da caixa: " );

        //            Console.WriteLine("  ______ __ \n" +
        //                               "/_____ /_ /\n" +
        //                               "| {0} | | \n" +
        //                               "|_____|/  ", caixas[i].cor);
        //        }
        //        else
        //        {
        //            notificar.ApresentarMensagem("Nenhuma revista cadastrada!!!", ConsoleColor.Yellow);
        //            break;
        //        }              
        //    }
        //}
        #endregion
    }
}
