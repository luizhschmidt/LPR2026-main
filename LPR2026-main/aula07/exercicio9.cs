using System;

class Exercicio8
{
    // Sala de cinema: 6 linhas (0 a 5) por 8 colunas (0 a 7)
    static int[,] sala = new int[6, 8];

    static void Main()
    {
        // Inicializa todas as cadeiras livres (0 = livre)
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                sala[i, j] = 0;
            }
        }

        int opcao = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE RESERVAS DO CINEMA");
            Console.WriteLine("1 - Reservar assento");
            Console.WriteLine("2 - Cancelar reserva");
            Console.WriteLine("3 - Consultar assento");
            Console.WriteLine("4 - Mostrar mapa da sala");
            Console.WriteLine("5 - Encerrar");
            Console.Write("Escolha uma opção: ");
            
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        ReservarAssento();
                        break;
                    case 2:
                        CancelarReserva();
                        break;
                    case 3:
                        ConsultarAssentoInterface();
                        break;
                    case 4:
                        MostrarMapa();
                        break;
                    case 5:
                        Console.WriteLine("\nEncerrando sistema... Obrigado!");
                        break;
                    default:
                        MensagemErro("Opção inválida!");
                        break;
                }
            }
            else
            {
                MensagemErro("Digite uma opção válida!");
            }

        } while (opcao != 5);
    }

    // Função de verificação exigida pelo exercício
    static string VerificarAssento(int linha, int coluna)
    {
        if (sala[linha, coluna] == 0)
            return "Livre";
        else
            return "Ocupado";
    }

    static void ReservarAssento()
    {
        Console.Clear();
        Console.WriteLine("--- Reservar Assento ---");
        ObterCoordenadas(out int linha, out int coluna);

        if (VerificarAssento(linha, coluna) == "Livre")
        {
            sala[linha, coluna] = 1; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nAssento [{linha},{coluna}] reservado com sucesso!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nErro: O assento [{linha},{coluna}] já está ocupado!");
            Console.ResetColor();
        }
        AguardarTecla();
    }

    static void CancelarReserva()
    {
        Console.Clear();
        Console.WriteLine("--- Cancelar Reserva ---");
        ObterCoordenadas(out int linha, out int coluna);

        if (VerificarAssento(linha, coluna) == "Ocupado")
        {
            sala[linha, coluna] = 0; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nReserva do assento [{linha},{coluna}] cancelada com sucesso!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nErro: O assento [{linha},{coluna}] já estava livre!");
            Console.ResetColor();
        }
        AguardarTecla();
    }

    static void ConsultarAssentoInterface()
    {
        Console.Clear();
        Console.WriteLine(" Consultar Assento");
        ObterCoordenadas(out int linha, out int coluna);

        string status = VerificarAssento(linha, coluna);
        Console.WriteLine($"\nO assento [{linha},{coluna}] está: {status}");
        AguardarTecla();
    }

    static void MostrarMapa()
    {
        Console.Clear();
        Console.WriteLine(" MAPA DA SALA (6x8)");
        Console.WriteLine("   [0] [1] [2] [3] [4] [5] [6] [7]  <- Colunas");
        
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"[{i}] "); 
            for (int j = 0; j < 8; j++)
            {
                if (sala[i, j] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" L  "); 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" O  "); 
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nLegenda: L = Livre (Verde) | O = Ocupado (Vermelho)");
        AguardarTecla();
    }

    static void ObterCoordenadas(out int linha, out int col)
    {
        Console.Write("Digite a Linha (0 a 5): ");
        while (!int.TryParse(Console.ReadLine(), out linha) || linha < 0 || linha > 5)
        {
            Console.Write("Linha inválida! Digite um valor entre 0 e 5: ");
        }

        Console.Write("Digite a Coluna (0 a 7): ");
        while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col > 7)
        {
            Console.Write("Coluna inválida! Digite um valor entre 0 e 7: ");
        }
    }

    static void MensagemErro(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{mensagem}");
        Console.ResetColor();
        AguardarTecla();
    }

    static void AguardarTecla()
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar");
        Console.ReadKey();
    }
}