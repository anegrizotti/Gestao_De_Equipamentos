using System;

namespace Gestao_De_Equipamentos.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region variáveis
            int[] idEquipamento = new int[1000];
            string[] nomeEquipamento = new string[1000];
            decimal[] precoEquipamento = new decimal[1000];
            string[] numeroSerieEquipamento = new string[1000];
            string[] stringDataDeFabricacaoEquipamento = new string[1000];
            DateTime[] dateDataDeFabricacaoEquipamento = new DateTime[1000];
            string[] nomeFabricanteEquipamento = new string[1000];
            bool[] equipamentoTemChamado = new bool[1000];
            string[] novoNomeEquipamento = new string[1000];
            decimal[] novoPrecoEquipamento = new decimal[1000];
            string[] novoNumeroSerieEquipamento = new string[1000];
            string[] stringNovoDataDeFabricacaoEquipamento = new string[1000];
            string[] novoNomeFabricanteEquipamento = new string[1000];
            bool[] novoEquipamentoTemChamado = new bool[1000];
            int[] idChamado = new int[1000];
            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];
            string[] equipamentoChamado = new string[1000];
            string[] dataAberturaChamado = new string[1000];
            string[] situacaoChamado = new string[1000];
            int[] idSolicitanteChamado = new int[1000];
            DateTime[] dateDataAberturaChamado = new DateTime[1000];
            string[] novoTituloChamado = new string[1000];
            string[] novoDescricaoChamado = new string[1000];
            string[] novoEquipamentoChamado = new string[1000];
            string[] novoDataAberturaChamado = new string[1000];
            string[] novoSituacaoChamado = new string[1000];
            DateTime[] novoDateDataAberturaChamado = new DateTime[1000];
            int[] idSolicitante = new int[1000];
            string[] nomeSolicitante = new string[1000];
            string[] emailSolicitante = new string[1000];
            string[] telefoneSolicitante = new string[1000];
            int[] novoIdSolicitante = new int[1000];
            string[] novoNomeSolicitante = new string[1000];
            string[] novoEmailSolicitante = new string[1000];
            string[] novoTelefoneSolicitante = new string[1000];
            int controleIndiceEquipamentos = 0;
            int controleIndiceChamado = 0;
            int controleIndiceSolicitante = 0;
            string opcaoMenu;
            string continuar;
            #endregion

            #region controles/verificadores de entrada
            do
            {
                opcaoMenu = menuInicial();
                Console.Clear();

            } while (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "3" && opcaoMenu != "4" && opcaoMenu != "5"
            && opcaoMenu != "6" && opcaoMenu != "7" && opcaoMenu != "8" && opcaoMenu != "9" && opcaoMenu != "10" 
            && opcaoMenu != "11" && opcaoMenu != "12" && opcaoMenu != "13");

            do
            {
                if (opcaoMenu == "1")
                {
                    do
                    {
                        continuar = cadastrarEquipamento(ref idEquipamento, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref dateDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado, ref controleIndiceEquipamentos);
                        Console.Clear();

                    } while (continuar == "S");

                    opcaoMenu = menuInicial();
                    continue;

                }

                if (opcaoMenu == "2")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Escolha uma opção:");
                    Console.ResetColor();
                    Console.WriteLine("1- Visualizar todos os equipamentos\n2- Visualizar equipamentos que mais dão problema");
                    Console.WriteLine();
                    Console.Write("Opção desejada: ");
                    string opcaoVisualizar = Console.ReadLine();
                    Console.WriteLine();

                    if (opcaoVisualizar == "1")
                    {
                        visualizarEquipamentos(ref opcaoMenu, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado);
                        opcaoMenu = menuInicial();
                        Console.Clear();
                        continue;
                    }
                    else if (opcaoVisualizar == "2")
                    {
                        visualizarMaisDaProblema(idChamado);
                        opcaoMenu = menuInicial();
                        Console.Clear();
                        continue;
                    }
                }

                if (opcaoMenu == "3")
                {
                    editarEquipamento(ref idEquipamento, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref dateDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "4")
                {
                    excluirEquipamento(ref idEquipamento, ref opcaoMenu, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado, ref novoNomeEquipamento, ref novoPrecoEquipamento, ref novoNumeroSerieEquipamento, ref stringNovoDataDeFabricacaoEquipamento, ref novoNomeFabricanteEquipamento, ref novoEquipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "5")
                {
                    cadastrarChamado(ref situacaoChamado, ref idChamado, ref idEquipamento, ref idSolicitante, ref idSolicitanteChamado, ref controleIndiceChamado, ref nomeEquipamento, ref numeroSerieEquipamento, ref equipamentoTemChamado, ref tituloChamado, ref descricaoChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado, ref controleIndiceEquipamentos);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "6")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Escolha uma opção:");
                    Console.ResetColor();
                    Console.WriteLine("1- Visualizar todos os chamados\n2- Visualizar chamados abertos\n3- Visualizar chamados fechados");
                    Console.WriteLine();
                    Console.Write("Opção desejada: ");
                    string opcaoVisualizar = Console.ReadLine();
                    Console.WriteLine();

                    if (opcaoVisualizar == "1") {
                        visualizarChamado(ref idChamado, ref tituloChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado);
                        opcaoMenu = menuInicial();
                        Console.Clear();
                        continue;
                    }
                    else if (opcaoVisualizar == "2")
                    {
                        visualizarChamadoAberto(tituloChamado, equipamentoChamado, dataAberturaChamado, situacaoChamado, idSolicitanteChamado, dateDataAberturaChamado);
                        opcaoMenu = menuInicial();
                        Console.Clear();
                        continue;
                    }
                    else if (opcaoVisualizar == "3")
                    {
                        visualizarChamadoFechado(tituloChamado, equipamentoChamado, dataAberturaChamado, situacaoChamado, idSolicitanteChamado, dateDataAberturaChamado);
                        opcaoMenu = menuInicial();
                        Console.Clear();
                        continue;
                    }

                }

                if (opcaoMenu == "7")
                {
                    editarChamado(ref situacaoChamado, ref idSolicitanteChamado, ref idChamado, ref tituloChamado, ref descricaoChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "8")
                {
                    excluirChamado(ref equipamentoTemChamado, ref situacaoChamado, ref novoSituacaoChamado, ref idChamado, ref tituloChamado, ref descricaoChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado, ref novoTituloChamado, ref novoDescricaoChamado, ref novoEquipamentoChamado, ref novoDataAberturaChamado, ref novoDateDataAberturaChamado);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "9")
                {
                    casastroSolicitante(ref idSolicitante, ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante, ref controleIndiceSolicitante);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "10")
                {
                    visualizarSolicitante(ref tituloChamado, ref idSolicitante, ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "11")
                {
                    editarSolicitante(ref idSolicitante, ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;

                }

                if (opcaoMenu == "12")
                {
                    excluirSolicitante(ref idSolicitante, ref nomeSolicitante, ref emailSolicitante, ref telefoneSolicitante, novoIdSolicitante, novoNomeSolicitante, novoEmailSolicitante, novoTelefoneSolicitante);
                    opcaoMenu = menuInicial();
                    Console.Clear();
                    continue;
                }

                if (opcaoMenu == "13")
                {
                    Environment.Exit(0);
                }

            } while (true);
        }
        #endregion

        #region métodos

        //arrumar problema
        private static void visualizarMaisDaProblema(int[] idChamado)
        {
            Console.Clear();

            int[] arrayChamadoAuxiliar = new int[1000];
            arrayChamadoAuxiliar = idChamado;

            Array.Sort(arrayChamadoAuxiliar);
            Array.Reverse(arrayChamadoAuxiliar);

            int contArray = 0;

            for (int k = 0; k < idChamado.Length; k++)
            {
                if (idChamado[k] != null)
                {
                    contArray++;
                }
            }

            int i = 0;
            int j = 0;

            while (i < contArray)
            {
                int numero = arrayChamadoAuxiliar[i];
                int quantidadeVezes = 0;

                while (arrayChamadoAuxiliar[i] == arrayChamadoAuxiliar[j])
                {
                    quantidadeVezes++;
                    j++;

                    if (j == contArray) 
                        break;
                }

                string sufixo = (quantidadeVezes > 1) ? " vezes" : " vez";

                Console.WriteLine("Equipamento com id "+numero + " deu problema " + quantidadeVezes + sufixo);

                i = j;
            }

        }

        private static void visualizarChamadoFechado(string[] tituloChamado, string[] equipamentoChamado, string[] dataAberturaChamado, string[] situacaoChamado, int[] idSolicitanteChamado, DateTime[] dateDataAberturaChamado)
        {
            int contChamados = 0;
            Console.Clear();

            for (int i = 0; i < situacaoChamado.Length; i++)
            {
                if (tituloChamado[i] != null)
                {
                    contChamados++;
                }
            }

            for (int i = 0; i < situacaoChamado.Length; i++)
            {
                if (situacaoChamado[i] == "F")
                {
                    Console.WriteLine("Título do chamado: " + tituloChamado[i]);
                    Console.WriteLine("Equipamento: " + equipamentoChamado[i]);
                    Console.WriteLine("Data de abertura do chamado: " + dataAberturaChamado[i]);
                    Console.WriteLine("Id do solicitante do chamado: " + idSolicitanteChamado[i]);

                    int totalDias = DateTime.Today.Subtract(dateDataAberturaChamado[i]).Days;

                    Console.WriteLine("Número de dias que o chamado está aberto: " + totalDias);

                    Console.WriteLine();
                }
            }
        }

        private static void visualizarChamadoAberto(string[] tituloChamado, string[] equipamentoChamado, string[] dataAberturaChamado, string[] situacaoChamado, int[] idSolicitanteChamado, DateTime[] dateDataAberturaChamado)
        {
            int contChamados = 0;
            Console.Clear();

            for (int i = 0; i < situacaoChamado.Length; i++)
            {
                if (tituloChamado[i] != null)
                {
                    contChamados++;
                }
            }

            for (int i = 0; i < situacaoChamado.Length; i++)
            {
                if (situacaoChamado[i] == "A")
                {
                    Console.WriteLine("Título do chamado: " + tituloChamado[i]);
                    Console.WriteLine("Equipamento: " + equipamentoChamado[i]);
                    Console.WriteLine("Data de abertura do chamado: " + dataAberturaChamado[i]);
                    Console.WriteLine("Id do solicitante do chamado: " + idSolicitanteChamado[i]);

                    int totalDias = DateTime.Today.Subtract(dateDataAberturaChamado[i]).Days;

                    Console.WriteLine("Número de dias que o chamado está aberto: " + totalDias);

                    Console.WriteLine();
                }
            }
        }

        private static void excluirSolicitante(ref int[] idSolicitante, ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante, int[] novoIdSolicitante, string[] novoNomeSolicitante, string[] novoEmailSolicitante, string[] novoTelefoneSolicitante)
        {
            int j = 0;

            Console.WriteLine("Digite o id do solicitante a ser excluído: ");
            int idSolicitanteExcluido = int.Parse(Console.ReadLine());

            for (int i = 0; i < idSolicitanteExcluido; i++)
            {
                if (idSolicitante[i] != idSolicitanteExcluido)
                {
                    novoIdSolicitante[j] = idSolicitante[i];
                    novoNomeSolicitante[j] = nomeSolicitante[i];
                    novoEmailSolicitante[j] = emailSolicitante[i];
                    novoTelefoneSolicitante[j] = telefoneSolicitante[i];

                    j++;
                    break;

                }
            }

            idSolicitante = novoIdSolicitante;
            nomeSolicitante = novoNomeSolicitante;
            emailSolicitante = novoEmailSolicitante;
            telefoneSolicitante = novoTelefoneSolicitante;

            Console.Clear();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solicitante excluido!");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void editarSolicitante(ref int[] idSolicitante, ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante)
        {
            Console.WriteLine("Digite o id do solicitante a ser editado: ");
            int indiceSolicitanteEditado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < idSolicitante.Length; i++)
            {
                if (indiceSolicitanteEditado == idSolicitante[i])
                {
                    Console.WriteLine("Digite o novo nome do solicitante: ");
                    nomeSolicitante[indiceSolicitanteEditado] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite o novo email do solicitante: ");
                    emailSolicitante[indiceSolicitanteEditado] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite o novo telefone do solicitante: ");
                    telefoneSolicitante[indiceSolicitanteEditado] = Console.ReadLine();
                    Console.WriteLine();

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Solicitante editado!");
                    Console.ResetColor();
                    Console.WriteLine();

                    break;
                }
            }
        }

        private static void visualizarSolicitante(ref string[] tituloChamado, ref int[] idSolicitante, ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante)
        {
            int contSolicitantes = 0;
            Console.Clear();

            for (int i = 0; i < nomeSolicitante.Length; i++)
            {
                if (nomeSolicitante[i] != null)
                {
                    contSolicitantes++;
                }
            }

            for (int i = 0; i < contSolicitantes; i++)
            {
                Console.WriteLine("Id do Solicitante: " + idSolicitante[i]);
                Console.WriteLine("Nome do solicitante: " + nomeSolicitante[i]);
                Console.WriteLine("Email do solicitante: " + emailSolicitante[i]);
                Console.WriteLine("Telefone do solicitante: " + telefoneSolicitante[i]);

                Console.WriteLine();
            }
        }

        private static int casastroSolicitante(ref int[] idSolicitante, ref string[] nomeSolicitante, ref string[] emailSolicitante, ref string[] telefoneSolicitante, ref int controleIndiceSolicitante)
        {

            Console.WriteLine("Digite o nome do solicitante: ");
            nomeSolicitante[controleIndiceSolicitante] = Console.ReadLine();
            Console.WriteLine();

            while (nomeSolicitante[controleIndiceSolicitante].Length < 6)
            {
                Console.WriteLine("O nome do solicitante deve ter no minimo 6 caracteres. Digite  novamente: ");
                nomeSolicitante[controleIndiceSolicitante] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Digite o id do solicitante: ");
            idSolicitante[controleIndiceSolicitante] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o email do solicitante: ");
            emailSolicitante[controleIndiceSolicitante] = Console.ReadLine();
            Console.WriteLine();

            while (emailSolicitante[controleIndiceSolicitante].Length < 1)
            {
                Console.WriteLine("O email do solicitante não pode ser vazio. Digite novamente: ");
                emailSolicitante[controleIndiceSolicitante] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Digite o telefone do solicitante: ");
            telefoneSolicitante[controleIndiceSolicitante] = Console.ReadLine();
            Console.WriteLine();

            while (telefoneSolicitante[controleIndiceSolicitante] == null || telefoneSolicitante[controleIndiceSolicitante].Length < 9 || telefoneSolicitante[controleIndiceSolicitante].Length > 9)
            {
                Console.WriteLine("O telefone do solicitante deve ter 9 digitos. Digite novamente: ");
                telefoneSolicitante[controleIndiceSolicitante] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solicitante cadastrado!");
            Console.ResetColor();
            Console.WriteLine();
            controleIndiceSolicitante++;
            return controleIndiceSolicitante;
        }
        
        private static void excluirChamado(ref bool[] equipamentoTemChamado, ref string[] situacaoChamado, ref string[] novoSituacaoChamado, ref int[] idChamado, ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado, ref string[] novoTituloChamado, ref string[] novoDescricaoChamado, ref string[] novoEquipamentoChamado, ref string[] novoDataAberturaChamado, ref DateTime[] novoDateDataAberturaChamado)
        {
            int j = 0;
            int indice = 0;

            Console.WriteLine("Digite o id do chamado a ser excluído: ");
            int idChamadoExcluido = int.Parse(Console.ReadLine());

            for (int k=0; k < idChamado.Length; k++)
            {
                if (idChamadoExcluido == idChamado[k])
                {
                    indice = k;
                }
            }


            if (equipamentoTemChamado[indice] != true)
            {
                for (int i = 0; i < idChamado.Length; i++)
                {
                    if (idChamado[i] != idChamadoExcluido)
                    {
                        novoTituloChamado[j] = tituloChamado[i];
                        novoDescricaoChamado[j] = descricaoChamado[i];
                        novoEquipamentoChamado[j] = equipamentoChamado[i];
                        novoDataAberturaChamado[j] = dataAberturaChamado[i];
                        novoDateDataAberturaChamado[j] = dateDataAberturaChamado[i];
                        novoSituacaoChamado[j] = situacaoChamado[i];

                        j++;
                        break;
                    }
                }

                tituloChamado = novoTituloChamado;
                descricaoChamado = novoDescricaoChamado;
                equipamentoChamado = novoEquipamentoChamado;
                dataAberturaChamado = novoDataAberturaChamado;
                dateDataAberturaChamado = novoDateDataAberturaChamado;
                situacaoChamado = novoSituacaoChamado;

                Console.Clear();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Chamado excluido!");
                Console.ResetColor();
                Console.WriteLine();
            } else
            {
                Console.WriteLine("O equipamento possui um chamado e não pode ser excluido!");
            }
        }

        private static void editarChamado(ref string[] situacaoChamado, ref int[] idSolicitanteChamado, ref int[] idChamado, ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado)
        {
            Console.WriteLine("Digite o id do chamado a ser alterado: ");
            int idChamadoAlterado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < idChamado.Length; i++)
            {
                if (idChamadoAlterado == idChamado[i])
                {

                    Console.WriteLine("Digite um novo título para o chamado: ");
                    tituloChamado[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite uma nova descrição para o chamado: ");
                    descricaoChamado[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite uma nova data de abertura para o chamado: ");
                    dataAberturaChamado[i] = Console.ReadLine();
                    dateDataAberturaChamado[i] = Convert.ToDateTime(dataAberturaChamado[i]);
                    Console.WriteLine();

                    Console.WriteLine("Digite uma nova situação para o chamado (Aberto ou Fechado): ");
                    situacaoChamado[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite um novo id solicitante para o chamado: ");
                    idSolicitanteChamado[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chamado editado!");
                    Console.ResetColor();
                    Console.WriteLine();

                    break;
                }
            }
        }

        private static void visualizarChamado(ref int[] idSolicitanteChamado, ref string[] tituloChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado)
        {
            int contChamados = 0;

            for (int i = 0; i < tituloChamado.Length; i++)
            {
                if (tituloChamado[i] != null)
                {
                    contChamados++;
                }
            }

            for (int i = 0; i < contChamados; i++)
            {
                Console.WriteLine("Título do chamado: " + tituloChamado[i]);
                Console.WriteLine("Equipamento: " + equipamentoChamado[i]);
                Console.WriteLine("Data de abertura do chamado: " + dataAberturaChamado[i]);
                Console.WriteLine("Id do solicitante do chamado: " + idSolicitanteChamado[i]);

                int totalDias = DateTime.Today.Subtract(dateDataAberturaChamado[i]).Days;

                Console.WriteLine("Número de dias que o chamado está aberto: " + totalDias);

                Console.WriteLine();
            }
        }

        // arrumar
        private static void cadastrarChamado(ref string[] situacaoChamado, ref int[] idChamado, ref int[] idEquipamento, ref int[] idSolicitante, ref int[] idSolicitanteChamado, ref int controleIndiceChamado, ref string[] nomeEquipamento, ref string[] numeroSerieEquipamento, ref bool[] equipamentoTemChamado, ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado, ref int controleDeIndice)
        {
            Console.WriteLine("Digite o id do equipamento para registrar um chamado: ");
            int idEquipamentoChamado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool continuar = true;

            for (int i = 0; i < idEquipamento.Length; i++)
            {
                if (idEquipamentoChamado == idEquipamento[i])
                {
                    equipamentoTemChamado[i] = true;

                    Console.WriteLine("Digite o id do chamado: ");
                    idChamado[controleIndiceChamado] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Digite o id do solicitante do chamado: ");
                    idSolicitanteChamado[controleIndiceChamado] = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    while (continuar == true)
                    {
                        for (int j=0; j < idSolicitante.Length; j++)
                        {
                            if (idSolicitanteChamado[controleIndiceChamado] == idSolicitante[j])
                            {
                                continuar = false;
                                break;
                            }
                        }

                        if (continuar == true)
                        {
                            Console.WriteLine("O id do solicitante do chamado não existe. Digite novamente: ");
                            idSolicitanteChamado[controleIndiceChamado] = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }
                    }

                    Console.WriteLine("Digite o título do chamado: ");
                    tituloChamado[controleIndiceChamado] = Console.ReadLine();
                    Console.WriteLine();


                    while (tituloChamado[controleIndiceChamado].Length < 1)
                    {
                        Console.WriteLine("O título do chamado não pode ser vazio. Digite novamente: ");
                        tituloChamado[controleIndiceChamado] = Console.ReadLine();
                        Console.WriteLine();
                    }

                    Console.WriteLine("Digite a descrição do chamado: ");
                    descricaoChamado[controleIndiceChamado] = Console.ReadLine();
                    Console.WriteLine();

                    while (descricaoChamado[controleIndiceChamado].Length < 1)
                    {
                        Console.WriteLine("A descrição do chamado não pode ser vazia. Digite novamente: ");
                        descricaoChamado[controleIndiceChamado] = Console.ReadLine();
                        Console.WriteLine();
                    }

                    equipamentoChamado[controleIndiceChamado] = nomeEquipamento[i];

                    Console.WriteLine("Digite a data de abertura do chamado: ");
                    dateDataAberturaChamado[controleIndiceChamado] = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Digite a situação do chamado (A para ABERTO ou F para FECHADO): ");
                    situacaoChamado[controleIndiceChamado] = Console.ReadLine();
                    Console.WriteLine();

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chamado cadastrado!");
                    Console.ResetColor();
                    Console.WriteLine();

                    controleIndiceChamado++;

                    break;

                } else
                {
                    Console.WriteLine("O id do equipamento digitado não existe!");
                    break;
                }
            } 
        }

        private static void excluirEquipamento(ref int[] idEquipamento, ref string opcaoMenu, ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dateDataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado, ref string[] novoNomeEquipamento, ref decimal[] novoPrecoEquipamento, ref string[] novoNumeroSerieEquipamento, ref string[] novoDateDataDeFabricacaoEquipamento, ref string[] novoNomeFabricanteEquipamento, ref bool[] novoEquipamentoTemChamado)
        {
            int indiceEquipamentoRemovido = 0;
            int j = 0;
            bool continuar = true;

            Console.WriteLine("Digite o id do equipamento a ser removido: ");
            int idRemovido = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (idRemovido == idEquipamento[i] && equipamentoTemChamado[i])
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O equipamento possui um chamado e não pode ser removido no momento!");
                    Console.ResetColor();
                    Console.WriteLine();
                    continuar = false;

                } else if (idRemovido == idEquipamento[i])
                {
                    indiceEquipamentoRemovido = i;
                    break;
                }
            }

            if (continuar == true)
            {
                for (int i = 0; i < idEquipamento.Length; i++)
                {
                    if (i != indiceEquipamentoRemovido)
                    {
                        novoNomeEquipamento[j] = nomeEquipamento[i];
                        novoPrecoEquipamento[j] = precoEquipamento[i];
                        novoNumeroSerieEquipamento[j] = numeroSerieEquipamento[i];
                        novoDateDataDeFabricacaoEquipamento[j] = dateDataDeFabricacaoEquipamento[i];
                        novoNomeFabricanteEquipamento[j] = nomeFabricanteEquipamento[i];
                        novoEquipamentoTemChamado[j] = equipamentoTemChamado[i];

                        j++;
                    }
                }

                nomeEquipamento = novoNomeEquipamento;
                precoEquipamento = novoPrecoEquipamento;
                numeroSerieEquipamento = novoNumeroSerieEquipamento;
                dateDataDeFabricacaoEquipamento = novoDateDataDeFabricacaoEquipamento;
                nomeFabricanteEquipamento = novoNomeFabricanteEquipamento;
                equipamentoTemChamado = novoEquipamentoTemChamado;

                Console.Clear();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Equipamento excluido!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        private static void editarEquipamento(ref int[] idEquipamento, ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref DateTime[] dateDataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado)
        {
            Console.WriteLine("Digite o id do equipamento a ser editado: ");
            int idEquipamentoEditado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (idEquipamentoEditado == idEquipamento[i])
                {
                    Console.WriteLine("Digite o novo nome do equipamento: ");
                    nomeEquipamento[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite o novo preço do equipamento: ");
                    precoEquipamento[i] = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Digite o novo número de série do equipamento: ");
                    numeroSerieEquipamento[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite a nova data de fabricação do equipamento: ");
                    dataDeFabricacaoEquipamento[i] = Console.ReadLine();
                    dateDataDeFabricacaoEquipamento[i] = Convert.ToDateTime(dataDeFabricacaoEquipamento[i]);
                    Console.WriteLine();

                    Console.WriteLine("Digite o novo nome do fabricante do equipamento: ");
                    nomeFabricanteEquipamento[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("O equipamento tem chamado (S para SIM ou N para NÃO): ");
                    string chamado = Console.ReadLine();
                    Console.WriteLine();

                    if (chamado == "S")
                    {
                        equipamentoTemChamado[i] = true;
                    }
                    else if (chamado == "N")
                    {
                        equipamentoTemChamado[i] = false;
                    }
                }
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento editado!");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static string visualizarEquipamentos(ref string opcaoMenu, ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado)
        {
            int naoNulos = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Equipamentos cadastrados:");
            Console.ResetColor();
            Console.WriteLine();

            for (int i = 0; i < nomeEquipamento.Length; i++)
            {
                if (nomeEquipamento[i] != null)
                {
                    naoNulos++;
                }
            }

            for (int i = 0; i < naoNulos; i++)
            {
                if (naoNulos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não há equipamentos cadastrados no momento!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Nome do equipamento: " + nomeEquipamento[i]);
                    Console.WriteLine("Número de série do equipamento: " + numeroSerieEquipamento[i]);
                    Console.WriteLine("Nome do fabricante: " + nomeFabricanteEquipamento[i]);
                    Console.WriteLine();
                }
            }

            return opcaoMenu;
        }

        private static string menuInicial()
        {
            string opcaoMenu;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Escolha uma opção válida:");
            Console.ResetColor();
            Console.WriteLine("1- Registrar quipamento\n2- Visualizar equipamentos\n3- Editar equipamento\n" +
            "4- Excluir equipamento\n5- Registrar chamado\n6- Visualizar chamados\n7- Editar chamado\n8- Excluir chamado\n9- Registrar solicitante\n" +
            "10- Visualizar todos os solicitantes\n11- Editar solicitante\n12- Excluir solicitante\n13- Sair do programa");

            Console.WriteLine();
            Console.Write("Opção desejada: ");
            opcaoMenu = Console.ReadLine();
            Console.WriteLine();

            return opcaoMenu;
        }

        //verificar se data é válida
        private static string cadastrarEquipamento(ref int[] idEquipamento, ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref DateTime[] dateDataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado, ref int controleDeIndice)
        {
            string continuar;

            Console.WriteLine("Digite o id do equipamento: ");
            idEquipamento[controleDeIndice] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o nome do equipamento: ");
            nomeEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();

            while (nomeEquipamento[controleDeIndice].Length < 6)
            {
                Console.WriteLine("O nome do equipamento deve ter no minimo 6 caracteres. Digite novamente: ");
                nomeEquipamento[controleDeIndice] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Digite o preço do equipamento: ");
            precoEquipamento[controleDeIndice] = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            while (precoEquipamento[controleDeIndice] <= 0)
            {
                Console.WriteLine("O preço do equipamento deve ser maior do que zero. Digite novamente: ");
                precoEquipamento[controleDeIndice] = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Digite o número de série do equipamento: ");
            numeroSerieEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();


            while (controleDeIndice != 0)
            {
                for (int i = 0; i < numeroSerieEquipamento.Length; i++)
                {
                    if (numeroSerieEquipamento[controleDeIndice] == numeroSerieEquipamento[i] || numeroSerieEquipamento[controleDeIndice].Length < 1)
                    {
                        Console.WriteLine("O número de série digitado já existe ou não pode ser vazio. Digite novamente: ");
                        numeroSerieEquipamento[controleDeIndice] = Console.ReadLine();
                        Console.WriteLine();
                        continue;
                    }
                }
            }

            Console.WriteLine("Digite a data de fabricação do equipamento: ");
            dateDataDeFabricacaoEquipamento[controleDeIndice] = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o nome do fabricante do equipamento: ");
            nomeFabricanteEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();

            while (nomeFabricanteEquipamento[controleDeIndice].Length < 1)
            {
                Console.WriteLine("O nome do fabricante do equipamento não pode ser vazio. Digite novamente: ");
                nomeFabricanteEquipamento[controleDeIndice] = Console.ReadLine();
                Console.WriteLine();
            }

            equipamentoTemChamado[controleDeIndice] = false;
            
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento cadastrado!");
            Console.ResetColor();
            Console.WriteLine();
            controleDeIndice++;

            Console.WriteLine("Cadastrar outro equipamento (S para SIM ou N para NÃO): ");
            continuar = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();

            return continuar;
        }
        #endregion

    }
}
