using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_do_livro.ConsoleApp
{
    public class Menu
    {
        public string opcao;
        #region criação dos objetos
        Amigo[] amigos = new Amigo[100];
        Caixa[] caixa = new Caixa[100];
        Emprestimo[] emprestimo = new Emprestimo[100];
        Revista[] revista = new Revista[100];
        Reserva[] reserva = new Reserva[100];
        Categoria[] categoria = new Categoria[100];
        #endregion

        #region Menu e suas opções
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
            Console.WriteLine("7 - Cadastrar emprestimo \n8 - Visualizar emprestimos \n9 - Visualizar emprestimos no mês \n10 - Visualizar emprestimos em aberto");

            notificar.ApresentarMensagemSemReadLine("=====RESERVAS=====", ConsoleColor.DarkGreen);
            Console.WriteLine("11 - Cadastrar reserva \n12 - Visualizar reservas");

            notificar.ApresentarMensagemSemReadLine("=====CATEGORIA=====", ConsoleColor.DarkGreen);
            Console.WriteLine("13 - Cadastrar categoria \n14 - Visualizar categoria");

            notificar.ApresentarMensagemSemReadLine("=====(S - Sair)=====", ConsoleColor.DarkGreen);
            notificar.ApresentarMensagemSemReadLine("Opção:", ConsoleColor.DarkBlue);
            opcao = Console.ReadLine();

            Console.Clear();
        }
        public void VerificaOpcaoEscolhida()
        {
            if (opcao == "1")
            {
                RegistrarAmigo();
            }
            else if (opcao == "2")
            {
                ExibirAmigo();
            }
            else if (opcao == "3")
            {
                RegistrarCaixa();
            }
            else if (opcao == "4")
            {
                ExibirCaixa();
            }
            else if (opcao == "5")
            {
                RegistrarRevista();
            }
            else if (opcao == "6")
            {
                ExibirRevista();
            }
            else if (opcao == "7")
            {
                RegistrarEmprestimo();
            }
            else if (opcao == "8")
            {
                ExibirEmprestimo();
            }
            else if (opcao == "9")
            {
                ExibirEmprestimoMensal();
            }
            else if (opcao == "10")
            {
                ExibirEmprestimoAberto();
            }
            else if (opcao == "11")
            {
                RegistrarReserva();
            }
            else if (opcao == "12")
            {
                ExibirReserva();
            }
            else if (opcao == "13")
            {
                RegistrarCategoria();
            }
            else if (opcao == "14")
            {
                ExibirCategoria();
            }else if (opcao == "povoar")
            {
                PovoarAtributosAmigo();
                PovoarAtributosCaixa();
                PovoarAtributosRevista();
                PovoarAtributosEmprestimo();
                PovoarAtributosCategoria();
            }
        }

        #region Ignorar a.T
        //public void ApresentarMenuInserirSair()
        //{
        //    Notificar notificar = new Notificar();
        //    notificar.ApresentarMensagemSemReadLine("==MENU==", ConsoleColor.DarkBlue);
        //    Console.WriteLine("Digite: \n1 - Inserir \n2 - Sair");
        //}
        #endregion

        #endregion

        #region Registrar
        #region Povoar atributos
        public void PovoarAtributosAmigo()
        {
            Amigo novoAmigo = new Amigo();

            string nomeAmigo = "joao";
            string enderecoAmigo = "Rua joãos";
            string responsavelAmigo = "Pai do joão";
            string telefoneAmigo = "48676777";

            novoAmigo.nome = nomeAmigo;
            novoAmigo.endereco = enderecoAmigo;
            novoAmigo.responsavel = responsavelAmigo;
            novoAmigo.telefone = telefoneAmigo;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                {
                    amigos[i] = novoAmigo;
                    break;
                }
            }


        }
        public void PovoarAtributosCaixa()
        {
            Caixa novaCaixa = new Caixa();

            string corDaCaixa = "azul escuro";
            string etiquetaCaixa = "HQS";
            string numeroCaixa = "1";

            novaCaixa.cor = corDaCaixa;
            novaCaixa.etiqueta = etiquetaCaixa;
            novaCaixa.numero = Convert.ToInt32(numeroCaixa);

            for (int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] == null)
                {
                    caixa[i] = novaCaixa;
                    break;
                }
            }
        }
        public void PovoarAtributosRevista()
        {
            Revista novaRevista = new Revista();
            string tipoRevista = "As aventuras de um agiota";
            string edicao = "2";
            string ano = "2006";
            string caixa = "HQS";
            string categoria = "Aventura e ação";

            novaRevista.tipoDaRevista = tipoRevista;
            novaRevista.numeroDaEdicao = Convert.ToInt32(edicao);
            novaRevista.anoDaRevista = Convert.ToInt32(ano);
            novaRevista.tipoDaCaixa = caixa;
            novaRevista.categoriaRevista = categoria;

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                {
                    revista[i] = novaRevista;
                    break;
                }
            }
        }
        public void PovoarAtributosEmprestimo()
        {
            Emprestimo novoEmprestimo = new Emprestimo();

            string revistaAmigo = "As aventuras de um agiota";
            string dataEmprestimo = "09/12/2021";
            string dataDevolucao = "02/01/2022";
            string amigoEmprestimo = "joao";

            novoEmprestimo.status = Emprestimo.StatusDoEmprestimo.Aberto;
            novoEmprestimo.revistaEmprestimo = revistaAmigo;
            novoEmprestimo.dataDeEmprestimo = Convert.ToDateTime(dataEmprestimo);
            novoEmprestimo.dataDeDevolucao = Convert.ToDateTime(dataDevolucao);
            novoEmprestimo.amigoDoEmprestimo = amigoEmprestimo;

            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] == null)
                {
                    emprestimo[i] = novoEmprestimo;
                    break;
                }
            }
        }
        public void PovoarAtributosCategoria()
        {
            Categoria novaCategoria = new Categoria();

            string strNome = "Aventura e ação";
            string dias = "5";
            string strRevista = "As aventuras de um agiota";

            novaCategoria.nome = strNome;
            novaCategoria.revista = strRevista;
            novaCategoria.quantidadeDeDias = Convert.ToInt32(dias);

            for (int i = 0; i < categoria.Length; i++)
            {
                if (categoria[i] == null)
                {
                    categoria[i] = novaCategoria;
                    break;
                }
            }
        }
        #endregion
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
                    break;
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
                    break;
                }
            }
        }
        public void VerificarExistenciaRevista(string revistas)
        {
            Notificar notificar = new Notificar();

            int numeroDeRevistasCadastradas = 0;
            bool revistaEncontrado = false;
            while (revistaEncontrado == false)
            {
                Console.WriteLine("Revista: ");
                revistas = Console.ReadLine();
                for (int i = 0; i < revista.Length; i++)
                {
                    if (revistas == revista[i].tipoDaRevista)
                    {
                        revistaEncontrado = true;
                        numeroDeRevistasCadastradas++;
                        break;
                    }
                    else if (revistas != revista[i].tipoDaRevista)
                    {
                        break;
                    }
                }
                if (numeroDeRevistasCadastradas == 0)
                {
                    notificar.ApresentarMensagem("Essa revista não está cadastrado!!!", ConsoleColor.DarkYellow);
                    Console.ReadLine();
                    continue;
                }
            }
        }
        public void VerificarExistenciaAmigo(string amigo)
        {
            int numeroDeAmigosCadastrados = 0;
            bool amigoEncontrado = false;
            while (amigoEncontrado == false)
            {
                Notificar notificar = new Notificar();
                Console.WriteLine("Amigo: ");
                amigo = Console.ReadLine();

                for (int i = 0; i < amigos.Length; i++)
                {
                    if (amigo == amigos[i].nome)
                    {
                        amigoEncontrado = true;
                        numeroDeAmigosCadastrados++;
                        break;
                    }
                    else if (amigo != amigos[i].nome)
                    {
                        break;
                    }
                }
                if (numeroDeAmigosCadastrados == 0)
                {
                    notificar.ApresentarMensagem("Esse amigo não está cadastrado!!!", ConsoleColor.DarkYellow);
                    Console.ReadLine();
                    continue;
                }
            }
        }
        public void VerificarExistenciaCaixa(string caixas)
        {
            Notificar notificar = new Notificar();
            int numeroDeCaixasCadastradas = 0;
            bool caixaEncontrada = false;
            while (caixaEncontrada == false)
            {
                Console.WriteLine("Caixa: ");
                caixas = Console.ReadLine();
                for (int i = 0; i < caixa.Length; i++)
                {
                    if (caixas == caixa[i].etiqueta)
                    {
                        caixaEncontrada = true;
                        numeroDeCaixasCadastradas++;
                        break;
                    }
                    else if (caixas != caixa[i].etiqueta)
                    {
                        break;
                    }
                }
                if (numeroDeCaixasCadastradas == 0)
                {
                    notificar.ApresentarMensagem("Essa caixa não existe!!!", ConsoleColor.DarkYellow);
                    Console.ReadLine();
                    continue;
                }

            }
        }
        public void VerificarExistenciaCategoria(string categorias)
        {
            Notificar notificar = new Notificar();
            int numeroDeCategoriaCadastradas = 0;
            bool categoriaEncontrada = false;
            while (categoriaEncontrada == false)
            {
                Console.WriteLine("Categoria: ");
                categorias = Console.ReadLine();
                for (int i = 0; i < caixa.Length; i++)
                {
                    if (categorias == categoria[i].nome)
                    {
                        categoriaEncontrada = true;
                        numeroDeCategoriaCadastradas++;
                        break;
                    }
                    else if (categorias != categoria[i].nome)
                    {
                        break;
                    }
                }
                if (numeroDeCategoriaCadastradas == 0)
                {
                    notificar.ApresentarMensagem("Essa categoria não existe!!!", ConsoleColor.DarkYellow);
                    Console.ReadLine();
                    continue;
                }

            }
        }
        public void VerificaDataDaReservaEhValida(string dataValidade)
        {
            Notificar notificar = new Notificar();
            bool dataValida = false;
            while (dataValida == false)
            {
                Console.WriteLine("Data da reserva:");
                dataValidade = Console.ReadLine();
                if (CalcularValidadeReserva(dataValidade) <= 0 && CalcularValidadeReserva(dataValidade) >= -2)
                {
                    dataValida = true;
                    break;
                }
                else if (CalcularValidadeReserva(dataValidade) < -2)
                {
                    notificar.ApresentarMensagem("Data inserida ultrapassou a validade da reserva!!!", ConsoleColor.DarkRed);
                    continue;
                }
            }
        }
        #region calculos envolvendo data
        public double CalcularValidadeReserva(string dataReserva)
        {
            DateTime data = Convert.ToDateTime(dataReserva);
            TimeSpan diferenca = DateTime.Today - data;
            double dias = diferenca.TotalDays;
            return dias;
        }
        public void CalcularDataDevolucao(string dataDevolucao, string data, int dias)
        {
            DateTime dataAbertura = Convert.ToDateTime(data);
            DateTime devolucao = Convert.ToDateTime(dataDevolucao);
            devolucao = dataAbertura.AddDays(dias);
        }

        #endregion
        public void RegistrarEmprestimo()
        {
            ExibirAmigo();
            ExibirRevista();

            Emprestimo novoEmprestimo = new Emprestimo();
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Registrar=emprestimo===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            Console.WriteLine("Status: Aberto");

            string revistaAmigo = "";
            VerificarExistenciaRevista(revistaAmigo);

            Console.WriteLine("Data do emprestimo: ");
            string dataEmprestimo = Console.ReadLine();

            string dataDevolucao = "";
            for(int i = 0; i < revista.Length; i++)
            {
                if(categoria != null)
                {
                    CalcularDataDevolucao(dataDevolucao, dataEmprestimo, categoria[i].quantidadeDeDias);
                }
                
            }

            string amigoEmprestimo = "";
            VerificarExistenciaAmigo(amigoEmprestimo);

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
                    break;
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

            ExibirCaixa();
            string caixas = "";
            VerificarExistenciaCaixa(caixas);

            ExibirCategoria();
            string categoria = "";
            VerificarExistenciaCategoria(categoria);

            novoRevista.tipoDaRevista = tipoRevista;
            novoRevista.numeroDaEdicao = Convert.ToInt32(edicao);
            novoRevista.anoDaRevista = Convert.ToInt32(ano);
            novoRevista.tipoDaCaixa = caixas;
            novoRevista.categoriaRevista = categoria;

            for(int i = 0; i < revista.Length; i++)
            {
                if(revista[i] == null)
                {
                    revista[i] = novoRevista;
                    break;
                }
            }

        }

        public void RegistrarReserva()
        {
            Reserva novaReserva = new Reserva();
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Registrar=reserva===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            string strData = "";
            VerificaDataDaReservaEhValida(strData);

            ExibirRevista();
            string strRevista = "";
            VerificarExistenciaRevista(strRevista);

            ExibirAmigo();
            string strAmigo = "";
            VerificarExistenciaAmigo(strAmigo);

            novaReserva.dataReserva = Convert.ToDateTime(strData);
            novaReserva.revista = strRevista;
            novaReserva.amigo = strAmigo;

            for (int i = 0; i < reserva.Length; i++)
            {
                if(reserva[i] == null)
                {
                    reserva[i] = novaReserva;
                    break;
                }
            }
        }

        public void RegistrarCategoria()
        {
            Categoria novaCategoria = new Categoria();

            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Registrar=categoria===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            Console.WriteLine("Nome da categoria:");
            string strNome = Console.ReadLine();

            Console.WriteLine("Quantidade de dias para emprestimo");
            string dias = Console.ReadLine();

            ExibirRevista();
            string strRevista = "";
            VerificarExistenciaRevista(strRevista);

            novaCategoria.nome = strNome;
            novaCategoria.revista = strRevista;
            novaCategoria.quantidadeDeDias = Convert.ToInt32(dias);

            for (int i = 0; i < categoria.Length; i++)
            {
                if(categoria[i] == null)
                {
                    categoria[i] = novaCategoria;
                    break;
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

            int numeroDeAmigosCadastrados = 0;
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine("Amigo: {0}, Endereço: {1}, Responsavel: {2}, Telefone: {3}", amigos[i].nome, amigos[i].endereco, amigos[i].responsavel, amigos[i].telefone);
                    numeroDeAmigosCadastrados++;
                }
                
            }
            if (numeroDeAmigosCadastrados == 0)
            {
                notificar.ApresentarMensagem("Nenhum amigo cadastrado!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }
        public void ExibirCaixa()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visualizar=caixa===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            int numeroDeCaixaRegistradas = 0;
            for(int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] != null)
                {
                    Console.WriteLine("Etiqueta: {0}, Número: {1}", caixa[i].etiqueta, caixa[i].numero);
                    Console.WriteLine("Cor da caixa: " + caixa[i].cor);

                    visualizarCorDaCaixa("  __ _________ __ \n" +
                                         " /__/________ /_ /\n" +
                                         "    |        | | \n" +
                                         "    |________|/  ");
                    numeroDeCaixaRegistradas++;
                }
            }
            if(numeroDeCaixaRegistradas == 0)
            {
                notificar.ApresentarMensagem("Nenhum caixa cadastrado!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }

        public void visualizarCorDaCaixa(string mensagem)
        {
            ConsoleColor cor = default;
            for (int i = 0; i < caixa.Length; i++)
            {
                if(caixa[i] != null)
                {
                    if (caixa[i].cor == "azul")
                    {
                        cor = ConsoleColor.Blue;
                    }
                    if (caixa[i].cor == "azul escuro")
                    {
                        cor = ConsoleColor.DarkBlue;
                    }
                    if (caixa[i].cor == "vermelho")
                    {
                        cor = ConsoleColor.Red;
                    }
                    if (caixa[i].cor == "vermelho escuro")
                    {
                        cor = ConsoleColor.DarkRed;
                    }
                    if (caixa[i].cor == "verde")
                    {
                        cor = ConsoleColor.Green;
                    }
                    if (caixa[i].cor == "verde escuro")
                    {
                        cor = ConsoleColor.DarkGreen;
                    }
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

            int numeroDeRevistasCadastradas = 0;
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] != null)
                {
                    Console.WriteLine("Tipo da revista: {0}, Edição: {1}, Ano: {2}, Caixa da revista: {3}, Categoria: {4}",revista[i].tipoDaRevista, revista[i].numeroDaEdicao, revista[i].anoDaRevista, revista[i].tipoDaCaixa, revista[i].categoriaRevista);
                    
                     Console.WriteLine("Cor da caixa: " + caixa[i].cor);

                     visualizarCorDaCaixa("  __ _________ __ \n" +
                                         " /__/________ /_ /\n" +
                                         "    |        | | \n" +
                                         "    |________|/  ");

                    numeroDeRevistasCadastradas++;
                }
            }
            if(numeroDeRevistasCadastradas == 0)
            {
                notificar.ApresentarMensagem("Nenhuma revista cadastrada!!!", ConsoleColor.DarkYellow);
            }else
                Console.ReadLine();
        }

        public void EscreverEmprestimo(int i)
        {
            Console.WriteLine("Status: {0}, Revista: {1}, Data do emprestimo: {2}, Data de devolução: {3}, Amigo: {4}", emprestimo[i].status, emprestimo[i].revistaEmprestimo, emprestimo[i].dataDeEmprestimo.ToString("dd/MM/yyyy"), emprestimo[i].dataDeDevolucao.ToString("dd/MM/yyyy"), emprestimo[i].amigoDoEmprestimo);
        }
        public void ExibirEmprestimo()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visulaizar=emprestimos===", ConsoleColor.DarkGreen);
            Console.WriteLine("");
            int numeroDeRevistas = 0;
            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] != null)
                {
                    EscreverEmprestimo(i);
                    numeroDeRevistas++;
                }
            }
            if (numeroDeRevistas == 0)
            {
                notificar.ApresentarMensagem("Nenhum emprestimo cadastrado!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }

        public void ExibirEmprestimoMensal()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visulaizar=emprestimos=mensal===", ConsoleColor.DarkGreen);
            Console.WriteLine("");
            int numeroDeRevistas = 0;
            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] != null)
                {
                    Console.WriteLine("Insira o mês que deseja vizualir os emprestimos:");
                    string strMes = Console.ReadLine();
                    int mes = Convert.ToInt32(strMes);

                    if (emprestimo[i].dataDeEmprestimo.Month == mes)
                    {
                        EscreverEmprestimo(i);
                        numeroDeRevistas++;
                    }
                }
            }
            if (numeroDeRevistas == 0)
            {
                notificar.ApresentarMensagem("Nenhum emprestimo cadastrado!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }

        public void ExibirEmprestimoAberto()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visulaizar=emprestimos=abertos===", ConsoleColor.DarkGreen);
            Console.WriteLine("");
            int numeroDeRevistas = 0;
            for (int i = 0; i < emprestimo.Length; i++)
            {
                if (emprestimo[i] != null)
                {
                    if (emprestimo[i].status == Emprestimo.StatusDoEmprestimo.Aberto)
                    {
                        EscreverEmprestimo(i);
                        numeroDeRevistas++;
                    }
                }
            }
            if (numeroDeRevistas == 0)
            {
                notificar.ApresentarMensagem("Nenhum emprestimo cadastrado!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }

        public void ExibirCategoria()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visualizar=categorias===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            int numeroDeCategoriasRegistradas = 0;
            for (int i = 0; i < categoria.Length; i++)
            {
                if (categoria[i] != null)
                {
                    Console.WriteLine("Categoria {0} pode ser emprestada apenas por {1} dias, Revista selecionada: {2}", categoria[i].nome, categoria[i].quantidadeDeDias, categoria[i].revista);
                    numeroDeCategoriasRegistradas++;
                }
            }
            if (numeroDeCategoriasRegistradas == 0)
            {
                notificar.ApresentarMensagem("Nenhuma categoria cadastrada!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }

        public void ExibirReserva()
        {
            Notificar notificar = new Notificar();
            notificar.ApresentarMensagemSemReadLine("===Visualizar=reservas===", ConsoleColor.DarkGreen);
            Console.WriteLine("");

            int numeroDeReservaRegistradas = 0;
            for (int i = 0; i < reserva.Length; i++)
            {
                if (reserva[i] != null)
                {
                    Console.WriteLine("Data: {0}, Revista: {1}, Amigo: {2}", reserva[i].dataReserva, reserva[i].revista, reserva[i].amigo);

                    numeroDeReservaRegistradas++;
                }
            }
            if (numeroDeReservaRegistradas == 0)
            {
                notificar.ApresentarMensagem("Nenhuma reserva cadastrada!!!", ConsoleColor.DarkYellow);
            }
            else
            {
                Console.ReadLine();
            }
        }
        #endregion
    }
}
