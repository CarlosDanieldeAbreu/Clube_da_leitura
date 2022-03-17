using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_do_livro.ConsoleApp
{
    public class Emprestimo
    {
        public StatusDoEmprestimo status;
        public string revistaEmprestimo;
        public DateTime dataDeEmprestimo;
        public DateTime dataDeDevolucao;
        public string amigoDoEmprestimo;

        public enum StatusDoEmprestimo
        {
            Aberto, Fechado
        }

        #region codigo antes do tiago
        //public void CadastrarEmprestimo()
        //{
        //    int i = 0;
        //    Menu menu = new Menu();
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("===Cadastrar=emprestimo===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");

        //    while (true)
        //    {
        //        menu.ApresentarMenuInserirSair();
        //        string opcao = Console.ReadLine();
        //        Console.WriteLine("");

        //        if (opcao == "1")
        //        {
        //            status[i] = StatusDoEmprestimo.Aberto;
        //            Console.WriteLine("Status: Aberto");

        //            Console.WriteLine("Revista: ");
        //            string revistaAmigo = Console.ReadLine();
        //            revistaEmprestimo[i] = revistaAmigo.ToString();

        //            Console.WriteLine("Data do emprestimo: ");
        //            string dataEmprestimo = Console.ReadLine();
        //            dataDeEmprestimo[i] = Convert.ToDateTime(dataEmprestimo);

        //            Console.WriteLine("Data de devolução: ");
        //            string dataDevolucao = Console.ReadLine();
        //            dataDeDevolucao[i] = Convert.ToDateTime(dataDevolucao);

        //            Console.WriteLine("Amigo: ");
        //            string amigoEmprestimo = Console.ReadLine();
        //            amigoDoEmprestimo[i] = amigoEmprestimo.ToString(); 

        //            i++;
        //        }
        //        else if (opcao == "2")
        //        {
        //            break;
        //        }
        //    }
        //}

        //public void VisualizarEmprestimo()
        //{
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("===Visulaizar=emprestimos===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");
        //    for (int i = 0; i < revistaEmprestimo.Length; i++)
        //    {
        //        if (revistaEmprestimo[i] != null)
        //        {
        //            Console.WriteLine("Status: {0}, Revista: {1}, Data do emprestimo: {2}, Data de devolução: {3}, Amigo: {4}", status[i], revistaEmprestimo[i], dataDeEmprestimo[i], dataDeDevolucao[i], amigoDoEmprestimo[i]);
        //        }
        //        else
        //        {
        //            notificar.ApresentarMensagem("Nenhum emprestimo cadastrado!!!", ConsoleColor.Yellow);
        //            break;
        //        }
        //    }
        //}
        #endregion
    }
}
