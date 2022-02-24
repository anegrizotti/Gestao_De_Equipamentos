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
            string[] dataDeFabricacaoEquipamento = new string[1000];
            string[] nomeFabricanteEquipamento = new string[1000];
            bool[] equipamentoTemChamado = new bool[1000];
            string[] novoNomeEquipamento = new string[1000];
            decimal[] novoPrecoEquipamento = new decimal[1000];
            string[] novoNumeroSerieEquipamento = new string[1000];
            string[] novoDataDeFabricacaoEquipamento = new string[1000];
            string[] novoNomeFabricanteEquipamento = new string[1000];
            bool[] novoEquipamentoTemChamado = new bool[1000];
            int controleDeIndice = 0;
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
                        continuar = cadastrarEquipamento(ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref dataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado, ref controleDeIndice);

                    } while (continuar == "S");

                    opcaoMenu = menuInicial();
                    continue;

                }

                if (opcaoMenu == "2")
                {
                    visualizarEquipamentos(ref opcaoMenu, ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref dataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "3")
                {
                    editarEquipamento(ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref dataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado);
                    opcaoMenu = menuInicial();
                    continue;
                }

                if (opcaoMenu == "4")
                {
                    excluirEquipamento(ref nomeEquipamento, ref precoEquipamento, ref numeroSerieEquipamento, ref dataDeFabricacaoEquipamento, ref nomeFabricanteEquipamento, ref equipamentoTemChamado, ref novoNomeEquipamento, ref novoPrecoEquipamento, ref novoNumeroSerieEquipamento, ref novoDataDeFabricacaoEquipamento, ref novoNomeFabricanteEquipamento, ref novoEquipamentoTemChamado);
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
        private static void excluirEquipamento(ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado, ref string[] novoNomeEquipamento, ref decimal[] novoPrecoEquipamento, ref string[] novoNumeroSerieEquipamento, ref string[] novoDataDeFabricacaoEquipamento, ref string[] novoNomeFabricanteEquipamento, ref bool[] novoEquipamentoTemChamado)
        {
            int indiceEquipamentoRemovido = 0;
            int j = 0;

            Console.WriteLine("Digite o número de série do equipamento a ser removido: ");
            string numeroSerieRemovido = Console.ReadLine();

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (numeroSerieRemovido == numeroSerieEquipamento[i])
                {
                    indiceEquipamentoRemovido = i;
                    break;
                }
            }

            for (int i = 0; i < numeroSerieEquipamento.Length; i++)
            {
                if (i != indiceEquipamentoRemovido)
                {
                    novoNomeEquipamento[j] = nomeEquipamento[i];
                    novoPrecoEquipamento[j] = precoEquipamento[i];
                    novoNumeroSerieEquipamento[j] = numeroSerieEquipamento[i];
                    novoDataDeFabricacaoEquipamento[j] = dataDeFabricacaoEquipamento[i];
                    novoNomeFabricanteEquipamento[j] = nomeFabricanteEquipamento[i];
                    novoEquipamentoTemChamado[j] = equipamentoTemChamado[i];

                    j++;
                }
            }

            nomeEquipamento = novoNomeEquipamento;
            precoEquipamento = novoPrecoEquipamento;
            numeroSerieEquipamento = novoNumeroSerieEquipamento;
            dataDeFabricacaoEquipamento = novoDataDeFabricacaoEquipamento;
            nomeFabricanteEquipamento = novoNomeFabricanteEquipamento;
            equipamentoTemChamado = novoEquipamentoTemChamado;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Equipamento excluido!");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void editarEquipamento(ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado)
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
                Console.WriteLine("Nome do equipamento: "+nomeEquipamento[i]);
                Console.WriteLine("Preço do equipamento: "+precoEquipamento[i]);
                Console.WriteLine("Número de série do equipamento: "+numeroSerieEquipamento[i]);
                Console.WriteLine("Data de fabricação do equipamento: "+dataDeFabricacaoEquipamento[i]);
                Console.WriteLine("Nome do fabricante: "+nomeFabricanteEquipamento[i]);
                Console.WriteLine("Equipamento tem chamado: "+equipamentoTemChamado[i]);
                Console.WriteLine();
            }

            return opcaoMenu;
        }

        private static string menuInicial()
        {
            string opcaoMenu;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("1- Registrar quipamento\n2- Visualizar equipamentos\n3- Editar equipamento\n" +
            "4- Excluir equipamento\n5- Registrar chamado\n6- Visualizar todos os chamados\n7- Editar chamado\n8- Excluir chamado\n9- Finalizar programa");
            Console.ResetColor();

            opcaoMenu = Console.ReadLine();
            Console.WriteLine();

            return opcaoMenu;
        }

        private static string cadastrarEquipamento(ref string[] nomeEquipamento, ref decimal[] precoEquipamento, ref string[] numeroSerieEquipamento, ref string[] dataDeFabricacaoEquipamento, ref string[] nomeFabricanteEquipamento, ref bool[] equipamentoTemChamado, ref int controleDeIndice)
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
            Console.WriteLine();

            Console.WriteLine("Digite o nome do fabricante do equipamento: ");
            nomeFabricanteEquipamento[controleDeIndice] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("O equipamento tem chamado (S para SIM ou N para NÃO): ");
            string chamado = Console.ReadLine();
            Console.WriteLine();

            if (chamado == "S")
            {
                equipamentoTemChamado[controleDeIndice] = true;
            }
            else if (chamado == "N")
            {
                equipamentoTemChamado[controleDeIndice] = false;
            }

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
