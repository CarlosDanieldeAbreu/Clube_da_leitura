using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_do_livro.ConsoleApp
{
    internal class Menu
    {
        public string opcao;
        Amigo[] amigos = new Amigo[100];
        Caixa[] caixa = new Caixa[100];
        Emprestimo[] emprestimo = new Emprestimo[100];
        Revista[] revista = new Revista[100];

        public void ApresentarMenu()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("==MENU==", ConsoleColor.DarkBlue);
            Console.WriteLine("Digite:");

            notificar.ApresentarMensagemSemReadLine("=====AMIGOS=====", ConsoleColor.DarkGreen);
            Console.WriteLine("1 - Cadastrar Amigo \n2 - Visualizar amigos cadastrados");

            notificar.ApresentarMensagemSemReadLine("=====CAIXAS=====", ConsoleColor.DarkGreen);
            Console.WriteLine("3 - Cadastrar caixa \n4 - Visualizar caixas");

            notificar.ApresentarMensagemSemReadLine("=====REVISTAS=====", ConsoleColor.DarkGreen);
            Console.WriteLine("5 - Cadastrar revista \n6 - Visualizar revista");

            notificar.ApresentarMensagemSemReadLine("=====EMPRESTIMOS=====", ConsoleColor.DarkGreen);
            Console.WriteLine("7 - Cadastrar emprestimo \n8 - Visualizar emprestimos");

            notificar.ApresentarMensagemSemReadLine("=====S - Sair=====", ConsoleColor.DarkGreen);
            notificar.ApresentarMensagemSemReadLine("Opção:", ConsoleColor.DarkBlue);
            opcao = Console.ReadLine();

            Console.Clear();
        }

        #region Ignorar a.T
        //public void ApresentarMenuInserirSair()
        //{
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("==MENU==", ConsoleColor.DarkBlue);
        //    Console.WriteLine("Digite: \n1 - Inserir \n2 - Sair");
        //}
        #endregion

        public void VerificaOpcaoEscolhida()
        {
            if (opcao == "1")
            {
                RegistrarAmigo();
            }else if(opcao == "2")
            {
                ExibirAmigo();
            }else if(opcao == "3")
            {
                RegistrarCaixa();
            }else if (opcao == "4")
            {
                ExibirCaixa();
            }else if(opcao == "5")
            {
                RegistrarRevista();
            }else if(opcao == "6")
            {
                ExibirRevista();
            }else if(opcao == "7")
            {
                RegistrarEmprestimo();
            }else if(opcao == "8")
            {
                ExibirEmprestimo();
            }
        }

        #region Registros
        public void RegistrarAmigo()
        {
            Amigo novoAmigo = new Amigo();
            Notificar notificar = new Notificar();

            notificar.ApresentarMensagemSemReadLine("===Registrar=amigos===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            Console.WriteLine("Nome: ");
            string nomeAmigo = Console.ReadLine();

            Console.WriteLine("Endereço: ");
            string enderecoAmigo = Console.ReadLine();

            Console.WriteLine("Responsavel: ");
            string responsavelAmigo = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            string telefoneAmigo = Console.ReadLine();

            novoAmigo.nome = nomeAmigo;
            novoAmigo.endereco = enderecoAmigo;
            novoAmigo.responsavel = responsavelAmigo;
            novoAmigo.telefone = telefoneAmigo;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                {
                    amigos[i] = novoAmigo;
                }
            }
        }

        public void RegistrarCaixa()
        {
            Caixa novaCaixa = new Caixa();
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Registrar=caixa===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            Console.WriteLine("Cor: ");
            string corDaCaixa = Console.ReadLine();

            Console.WriteLine("Etiqueta: ");
            string etiquetaCaixa = Console.ReadLine();

            Console.WriteLine("Número: ");
            string numeroCaixa = Console.ReadLine();

            novaCaixa.cor = corDaCaixa;
            novaCaixa.etiqueta = etiquetaCaixa;
            novaCaixa.numero = Convert.ToInt32(numeroCaixa);

            for (int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] == null)
                {
                    caixa[i] = novaCaixa;
                }
            }
        }

        public void RegistrarEmprestimo()
        {
            Emprestimo novoEmprestimo = new Emprestimo();
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Registrar=emprestimo===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            Console.WriteLine("Status: Aberto");

            string revistaAmigo = "";
            int x = 0;
            while (true)
            {
                Console.WriteLine("Revista: ");
                revistaAmigo = Console.ReadLine();

                if (revistaAmigo == revista[x].tipoDaRevista)
                {
                    break;
                }
                else
                {
                    notificar.ApresentarMensagem("Essa revista não está cadastrado!!!", ConsoleColor.Yellow);
                    Console.ReadLine();
                }
                x++;
            }

            Console.WriteLine("Data do emprestimo: ");
            string dataEmprestimo = Console.ReadLine();

            Console.WriteLine("Data de devolução: ");
            string dataDevolucao = Console.ReadLine();

            Console.WriteLine("Amigo: ");
            string amigoEmprestimo = Console.ReadLine();

            int j = 0;
            while (true)
            {
                Console.WriteLine("Amigo: ");
                amigoEmprestimo = Console.ReadLine();

                if (amigoEmprestimo == amigos[j].nome)
                {
                    break;
                }
                else
                {
                    notificar.ApresentarMensagem("Esse amigo não está cadastrado!!!", ConsoleColor.Yellow);
                    Console.ReadLine();
                }
                j++;
            }

            novoEmprestimo.status = Emprestimo.StatusDoEmprestimo.Aberto;
            novoEmprestimo.revistaEmprestimo = revistaAmigo;
            novoEmprestimo.dataDeEmprestimo = Convert.ToDateTime(dataEmprestimo);
            novoEmprestimo.dataDeDevolucao = Convert.ToDateTime(dataDevolucao);
            novoEmprestimo.amigoDoEmprestimo = amigoEmprestimo;

            for(int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] == null)
                {
                    emprestimo[i] = novoEmprestimo;
                }
            }
        }

        public void RegistrarRevista()
        {
            Revista novoRevista = new Revista();
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Registrar=revista===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            Console.WriteLine("Tipo da revista: ");
            string tipoRevista = Console.ReadLine();

            Console.WriteLine("Edição: ");
            string edicao = Console.ReadLine();

            Console.WriteLine("Ano: ");
            string ano = Console.ReadLine();

            string caixas = "";

            int j = 0;
            while (true)
            {
                Console.WriteLine("Caixa: ");
                caixas = Console.ReadLine();

                if (caixas == caixa[j].etiqueta)
                {
                    break;
                }
                else
                {
                    notificar.ApresentarMensagem("Essa caixa não existe", ConsoleColor.Yellow);
                    Console.ReadLine();
                }
                j++;
            }

            novoRevista.tipoDaRevista = tipoRevista;
            novoRevista.numeroDaEdicao = Convert.ToInt32(edicao);
            novoRevista.anoDaRevista = Convert.ToInt32(ano);
            novoRevista.tipoDaCaixa = caixas;

            for(int i = 0; i < revista.Length; i++)
            {
                if(revista[i] == null)
                {
                    revista[i] = novoRevista;
                }
            }

        }
        #endregion
        #region Exibir registros
        public void ExibirAmigo()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Amigos=cadastrados===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine("Amigo: {0}, Endereço: {1}, Responsavel: {2}, Telefone: {3}", amigos[i].nome, amigos[i].endereco, amigos[i].responsavel, amigos[i].telefone);
                }
                else
                {
                    notificar.ApresentarMensagem("Nenhum amigo cadastrado!!!", ConsoleColor.DarkYellow);
                    break;
                }
            }
        }
        public void ExibirCaixa()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visualizar=caixa===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            for(int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] != null)
                {
                    Console.WriteLine("Cor: {0}, Etiqueta: {1}, Número: {2}", caixa[i].cor, caixa[i].etiqueta, caixa[i].numero);
                }
                else
                {
                    notificar.ApresentarMensagem("Nenhum caixa cadastrado!!!", ConsoleColor.DarkYellow);
                    break;
                }
            }
        }

        public void visaulizarCorDaCaixa(string mensagem)
        {
            ConsoleColor cor = default;
            for (int i = 0; i < caixa.Length; i++)
            {
                if(caixa[i].cor == "azul")
                {
                    cor = ConsoleColor.Blue;
                }
                else if(caixa[i].cor == "azul escuro")
                {
                    cor = ConsoleColor.DarkBlue;
                }
                else if (caixa[i].cor == "vermelho")
                {
                    cor = ConsoleColor.Red;
                }
                else if (caixa[i].cor == "vermelho escuro")
                {
                    cor = ConsoleColor.DarkRed;
                }
                else if (caixa[i].cor == "verde")
                {
                    cor = ConsoleColor.Green;
                }
                else if (caixa[i].cor == "verde escuro")
                {
                    cor = ConsoleColor.DarkGreen;
                }
            }
            
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public void ExibirRevista()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visualizar=revistas===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] != null)
                {
                    Console.WriteLine("Tipo da revista: {0}, Edição: {1}, Ano: {2}, Caixa da revista: {3}",revista[i]. tipoDaCaixa, revista[i].numeroDaEdicao, revista[i].anoDaRevista, caixa[i].etiqueta);
                    Console.WriteLine("Cor da caixa: " + caixa[i].cor);

                    visaulizarCorDaCaixa("  __ _________ __ \n" +
                                         " /__/________ /_ /\n" +
                                         "    |        | | \n" +
                                         "    |________|/  ");
                }
                else
                {
                    notificar.ApresentarMensagem("Nenhuma revista cadastrada!!!", ConsoleColor.DarkYellow);
                    break;
                }
            }
        }
        public void ExibirEmprestimo()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visulaizar=emprestimos===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] != null)
                {
                    Console.WriteLine("Status: {0}, Revista: {1}, Data do emprestimo: {2}, Data de devolução: {3}, Amigo: {4}", emprestimo[i].status, emprestimo[i].revistaEmprestimo, emprestimo[i].dataDeEmprestimo, emprestimo[i].dataDeDevolucao, emprestimo[i].amigoDoEmprestimo);
                }
                else
                {
                    notificar.ApresentarMensagem("Nenhum emprestimo cadastrado!!!", ConsoleColor.DarkYellow);
                    break;
                }
            }
        }
        #endregion
    }
}
