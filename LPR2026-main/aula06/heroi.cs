using System;

class Program
{
    static string nome1 = "", poder1 = "";
    static int pontos1 = 0;

    static string nome2 = "", poder2 = "";
    static int pontos2 = 0;

    static string nome3 = "", poder3 = "";
    static int pontos3 = 0;

    static string nome4 = "", poder4 = "";
    static int pontos4 = 0;

    static string nome5 = "", poder5 = "";
    static int pontos5 = 0;

    static int e1 = 0, e2 = 0, e3 = 0;

    static void Main()
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;
                case 2:
                    selecionarEquipe();
                    break;
                case 3:
                    exibirEquipe();
                    break;
            }

        } while (opcao != 0);
    }

    static void cadastrarHeroi()
    {
        Console.WriteLine("\nCadastro de Heróis:");

        if (nome1 == "")
        {
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Poder: ");
            poder1 = Console.ReadLine();
            Console.Write("Pontuação: ");
            pontos1 = int.Parse(Console.ReadLine());
        }
        else if (nome2 == "")
        {
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Poder: ");
            poder2 = Console.ReadLine();
            Console.Write("Pontuação: ");
            pontos2 = int.Parse(Console.ReadLine());
        }
        else if (nome3 == "")
        {
            Console.Write("Nome: ");
            nome3 = Console.ReadLine();
            Console.Write("Poder: ");
            poder3 = Console.ReadLine();
            Console.Write("Pontuação: ");
            pontos3 = int.Parse(Console.ReadLine());
        }
        else if (nome4 == "")
        {
            Console.Write("Nome: ");
            nome4 = Console.ReadLine();
            Console.Write("Poder: ");
            poder4 = Console.ReadLine();
            Console.Write("Pontuação: ");
            pontos4 = int.Parse(Console.ReadLine());
        }
        else if (nome5 == "")
        {
            Console.Write("Nome: ");
            nome5 = Console.ReadLine();
            Console.Write("Poder: ");
            poder5 = Console.ReadLine();
            Console.Write("Pontuação: ");
            pontos5 = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Limite de 5 heróis atingido!");
        }
    }

    static void mostrarHerois()
    {
        if (nome1 != "") Console.WriteLine("1 - " + nome1);
        if (nome2 != "") Console.WriteLine("2 - " + nome2);
        if (nome3 != "") Console.WriteLine("3 - " + nome3);
        if (nome4 != "") Console.WriteLine("4 - " + nome4);
        if (nome5 != "") Console.WriteLine("5 - " + nome5);
    }

    static void selecionarEquipe()
    {
        Console.WriteLine("\nSelecione 3 heróis:");
        mostrarHerois();

        Console.Write("Escolha o herói 1: ");
        e1 = int.Parse(Console.ReadLine());

        Console.Write("Escolha o herói 2: ");
        e2 = int.Parse(Console.ReadLine());

        Console.Write("Escolha o herói 3: ");
        e3 = int.Parse(Console.ReadLine());
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;

        total += pegarPontos(e1);
        total += pegarPontos(e2);
        total += pegarPontos(e3);

        return total;
    }

    static int pegarPontos(int escolha)
    {
        switch (escolha)
        {
            case 1: return pontos1;
            case 2: return pontos2;
            case 3: return pontos3;
            case 4: return pontos4;
            case 5: return pontos5;
            default: return 0;
        }
    }

    static string pegarNome(int escolha)
    {
        switch (escolha)
        {
            case 1: return nome1;
            case 2: return nome2;
            case 3: return nome3;
            case 4: return nome4;
            case 5: return nome5;
            default: return "";
        }
    }

    static string pegarPoder(int escolha)
    {
        switch (escolha)
        {
            case 1: return poder1;
            case 2: return poder2;
            case 3: return poder3;
            case 4: return poder4;
            case 5: return poder5;
            default: return "";
        }
    }
                                        
    static void exibirEquipe()
    {
        Console.WriteLine("\n=== EQUIPE ===");

        mostrarHeroiEquipe(e1);
        mostrarHeroiEquipe(e2);
        mostrarHeroiEquipe(e3);

        Console.WriteLine("Pontuação Total: " + calcularPontuacaoTotal());
    }

    static void mostrarHeroiEquipe(int escolha)
    {
        Console.WriteLine(
            pegarNome(escolha) +
            " | Poder: " + pegarPoder(escolha) +
            " | Pontos: " + pegarPontos(escolha)
        );
    }
}