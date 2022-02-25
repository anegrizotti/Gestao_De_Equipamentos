using System;

namespace Gestao_De_Equipamentos.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region variáveis
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
            DateTime[] dateNovoDataDeFabricacaoEquipamento = new DateTime[1000];
            string[] novoNomeFabricanteEquipamento = new string[1000];
            bool[] novoEquipamentoTemChamado = new bool[1000];
            string[] tituloChamado = new string[1000];
            string[] descricaoChamado = new string[1000];
            string[] equipamentoChamado = new string[1000];
            string[] dataAberturaChamado = new string[1000];
            DateTime[] dateDataAberturaChamado = new DateTime[1000];
            string[] novoTituloChamado = new string[1000];
            string[] novoDescricaoChamado = new string[1000];
            string[] novoEquipamentoChamado = new string[1000];
            string[] novoDataAberturaChamado = new string[1000];
            DateTime[] novoDateDataAberturaChamado = new DateTime[1000];
            int controleDeIndice = 0;
            int controleIndiceChamado = 0;
            string opcaoMenu;
            string continuar;
            #endregion

            #region controles/verificadores de entrada
            do
            {
                opcaoMenu = menuInicial();

            } while (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "3" && opcaoMenu != "4" && opcaoMenu != "5"
            && opcaoMenu != "6" && opcaoMenu != "7" && opcaoMenu != "8" && opcaoMenu != "9");

            do
            {
                if (opcaoMenu == "1")
                {
                    do
                    {
                        continuar = cadastrarEquipamento(ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref dateDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado, ref controleDeIndice);

                    } while (continuar == "S");

                    opcaoMenu = menuInicial();
                    continue;

                }

                if (opcaoMenu == "2")
                {
                    visualizarEquipamentos(ref opcaoMenu, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "3")
                {
                    editarEquipamento(ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref dateDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "4")
                {
                    excluirEquipamento(ref opcaoMenu, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref stringDataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado, ref novoNomeEquipamento, ref novoPrecoEquipamento, ref novoNumeroSerieEquipamento, ref stringNovoDataDeFabricacaoEquipamento, ref novoNomeFabricanteEquipamento, ref novoEquipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "5")
                {
                    cadastrarChamado(ref controleIndiceChamado, ref nomeEquipamento, ref numeroSerieEquipamento, ref equipamentoTemChamado, ref tituloChamado, ref descricaoChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado, ref controleDeIndice);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "6")
                {
                    visualizarChamado(ref tituloChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "7")
                {
                    editarChamado(ref tituloChamado, ref descricaoChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "8")
                {
                    excluirChamado(ref tituloChamado, ref descricaoChamado, ref equipamentoChamado, ref dataAberturaChamado, ref dateDataAberturaChamado, ref novoTituloChamado, ref novoDescricaoChamado, ref novoEquipamentoChamado, ref novoDataAberturaChamado, ref novoDateDataAberturaChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "9")
                {
                    Environment.Exit(0);
                }

            } while (true);
        }
        #endregion

        #region métodos
        private static void excluirChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado, ref string[] novoTituloChamado, ref string[] novoDescricaoChamado, ref string[] novoEquipamentoChamado, ref string[] novoDataAberturaChamado, ref DateTime[] novoDateDataAberturaChamado)
        {
            int j = 0;

            Console.WriteLine("Digite o título do chamado a ser excluído: ");
            string tituloChamadoExcluido = Console.ReadLine();

            for (int i = 0; i < tituloChamado.Length; i++)
            {
                if (tituloChamado[i] != tituloChamadoExcluido)
                {
                    novoTituloChamado[j] = tituloChamado[i];
                    novoDescricaoChamado[j] = descricaoChamado[i];
                    novoEquipamentoChamado[j] = equipamentoChamado[i];
                    novoDataAberturaChamado[j] = dataAberturaChamado[i];
                    novoDateDataAberturaChamado[j] = dateDataAberturaChamado[i];

                    j++;
                    break;
                }
            }

            tituloChamado = novoTituloChamado;
            descricaoChamado = novoDescricaoChamado;
            equipamentoChamado = novoEquipamentoChamado;
            dataAberturaChamado = novoDataAberturaChamado;
            dateDataAberturaChamado = novoDateDataAberturaChamado;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado excluido!");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void editarChamado(ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado)
        {
            Console.WriteLine("Digite o título do chamado a ser alterado: ");
            string tituloChamadoAlterado = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < tituloChamado.Length; i++)
            {
                if (tituloChamadoAlterado == tituloChamado[i])
                {
                    Console.WriteLine("Nome do equipamento: " + equipamentoChamado[i]);
                    Console.WriteLine();

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

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chamado editado!");
                    Console.ResetColor();
                    Console.WriteLine();

                    break;
                }
            }
        }

        private static void visualizarChamado(ref string[] tituloChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado)
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

                int totalDias = DateTime.Today.Subtract(dateDataAberturaChamado[i]).Days;

                Console.WriteLine("Número de dias que o chamado está aberto: " + totalDias);

                Console.WriteLine();
            }
        }

        private static void cadastrarChamado(ref int controleIndiceChamado, ref string[] nomeEquipamento, ref string[] numeroSerieEquipamento, ref bool[] equipamentoTemChamado, ref string[] tituloChamado, ref string[] descricaoChamado, ref string[] equipamentoChamado, ref string[] dataAberturaChamado, ref DateTime[] dateDataAberturaChamado, ref int controleDeIndice)
        {
            Console.WriteLine("Digite o número de série do equipamento para registrar um chamado: ");
            int numeroSerieChamdo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (numeroSerieChamdo == int.Parse(numeroSerieEquipamento[i]))
                {
                    equipamentoTemChamado[i] = true;

                    Console.WriteLine("Digite o título do chamado: ");
                    tituloChamado[controleIndiceChamado] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Digite a descrição do chamado: ");
                    descricaoChamado[controleIndiceChamado] = Console.ReadLine();
                    Console.WriteLine();

                    equipamentoChamado[controleIndiceChamado] = nomeEquipamento[i];

                    Console.WriteLine("Digite a data de abertura do chamado: ");
                    dateDataAberturaChamado[controleIndiceChamado] = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chamado cadastrado!");
                    Console.ResetColor();
                    Console.WriteLine();

                    controleIndiceChamado++;

                    break;

                }
            }
        }

        private static void excluirEquipamento(ref string opcaoMenu, ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dateDataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado, ref string[] novoNomeEquipamento, ref decimal[] novoPrecoEquipamento, ref string[] novoNumeroSerieEquipamento, ref string[] novoDateDataDeFabricacaoEquipamento, ref string[] novoNomeFabricanteEquipamento, ref bool[] novoEquipamentoTemChamado)
        {
            int indiceEquipamentoRemovido = 0;
            int j = 0;
            bool continuar = true;

            Console.WriteLine("Digite o número de série do equipamento a ser removido: ");
            string numeroSerieRemovido = Console.ReadLine();

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (numeroSerieRemovido == numeroSerieEquipamento[i] && equipamentoTemChamado[i])
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O equipamento possui um chamado e não pode ser removido no momento!");
                    Console.ResetColor();
                    Console.WriteLine();
                    continuar = false;

                } else if (numeroSerieRemovido == numeroSerieEquipamento[i])
                {
                    indiceEquipamentoRemovido = i;
                    break;
                }
            }

            if (continuar == true)
            {
                for (int i = 0; i < numeroSerieEquipamento.Length; i++)
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

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Equipamento excluido!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        private static void editarEquipamento(ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref DateTime[] dateDataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado)
        {
            Console.WriteLine("Digite o número de série do equipamento a ser editado: ");
            string numeroSerieEditado = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (numeroSerieEditado == numeroSerieEquipamento[i])
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento editado!");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static string visualizarEquipamentos(ref string opcaoMenu, ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado)
        {
            int naoNulos = 0;
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Escolha uma opção:");
            Console.ResetColor();
            Console.WriteLine("1- Registrar quipamento\n2- Visualizar equipamentos\n3- Editar equipamento\n" +
            "4- Excluir equipamento\n5- Registrar chamado\n6- Visualizar todos os chamados\n7- Editar chamado\n8- Excluir chamado\n9- Finalizar programa");

            opcaoMenu = Console.ReadLine();
            Console.WriteLine();

            return opcaoMenu;
        }

        private static string cadastrarEquipamento(ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref DateTime[] dateDataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado, ref int controleDeIndice)
        {
            string continuar;
            Console.WriteLine("Digite o nome do equipamento: ");
            nomeEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o preço do equipamento: ");
            precoEquipamento[controleDeIndice] = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o número de série do equipamento: ");
            numeroSerieEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a data de fabricação do equipamento: ");
            dataDeFabricacaoEquipamento[controleDeIndice] = Console.ReadLine();
            dateDataDeFabricacaoEquipamento[controleDeIndice] = Convert.ToDateTime(dataDeFabricacaoEquipamento[controleDeIndice]);
            Console.WriteLine();

            Console.WriteLine("Digite o nome do fabricante do equipamento: ");
            nomeFabricanteEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();

            equipamentoTemChamado[controleDeIndice] = false;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento cadastrado!");
            Console.ResetColor();
            Console.WriteLine();
            controleDeIndice++;

            Console.WriteLine("Cadastrar outro equipamento (S para SIM ou N para NÃO): ");
            continuar = Console.ReadLine();
            Console.WriteLine();

            return continuar;
        }
        #endregion

    }
}
