using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_do_livro.ConsoleApp
{
    public class Amigo
    {
        public string nome;
        public string endereco;
        public string responsavel;
        public string telefone;

        #region codigo antes do Tiago
        //public void CadastrarAmigo()
        //{
        //    int i = 0;
        //    Menu menu = new Menu();
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("===Cadastrar=amigos===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");

        //    while (true)
        //    {
        //        menu.ApresentarMenuInserirSair();
        //        string opcao = Console.ReadLine();
        //        Console.WriteLine("");

        //        if (opcao == "1")
        //        {
        //            Console.WriteLine("Nome: ");
        //            string nomeAmigo = Console.ReadLine();
        //            nome[i] = nomeAmigo.ToString();

        //            Console.WriteLine("Endereço: ");
        //            string enderecoAmigo = Console.ReadLine();
        //            endereco[i] = enderecoAmigo.ToString();

        //            Console.WriteLine("Responsavel: ");
        //            string responsavelAmigo = Console.ReadLine();
        //            responsavel[i] = responsavelAmigo.ToString();

        //            Console.WriteLine("Telefone: ");
        //            string telefoneAmigo = Console.ReadLine();
        //            telefone[i] = telefoneAmigo.ToString();

        //            i++;
        //        }
        //        else if (opcao == "2")
        //        {
        //            break;
        //        }
        //    }
        //}

        //public void VisualizarAmigo()
        //{
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagem("===Amigos=cadastrados===", ConsoleColor.DarkGreen);
        //    Console.WriteLine("");

        //    for (int i = 0; i < nome.Length; i++)
        //    {
        //        if (nome[i] != null)
        //        {
        //            Console.WriteLine("Amigo: {0}, Endereço: {1}, Responsavel: {2}, Telefone: {3}", nome[i], endereco[i], responsavel[i], telefone[i]);
        //        }
        //        else
        //        {
        //            notificar.ApresentarMensagem("Nenhum amigo cadastrado!!!", ConsoleColor.Yellow);
        //            break;
        //        }
        //    }
        //}
        #endregion
    }
}
