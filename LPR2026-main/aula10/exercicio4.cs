using System;
using System.Globalization;

namespace aula10
{
    class Arma
    {
        public string Nome;
        public string Tipo;
        public double DanoBase;
        public int Preco;

        public double CalcularDano(bool temColete)
        {
            if (temColete)
            {
                return DanoBase * 0.75; 
            }
            return DanoBase;
        }

        public void ExibirStatusArma()
        {
            Console.WriteLine("Arma: " + Nome + " | Tipo: " + Tipo + " | Preço: $" + Preco + " | Dano Base: " + DanoBase.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

    class Jogador
    {
        public string Nickname;
        public string Lado; 
        public int Abates;
        public int Mortes;
        public int Dinheiro;
        public Arma ArmaEquipada;

        public double CalcularKD()
        {
            if (Mortes == 0)
            {
                return Abates; 
            }
            return (double)Abates / Mortes;
        }

        public bool ComprarArma(Arma novaArma)
        {
            if (Dinheiro >= novaArma.Preco)
            {
                Dinheiro -= novaArma.Preco;
                ArmaEquipada = novaArma;
                return true;
            }
            return false;
        }

        public void ExibirStatusJogador()
        {
            Console.WriteLine("Jogador: " + Nickname + " [" + Lado + "]");
            Console.WriteLine("K/D Ratio: " + CalcularKD().ToString("F2", CultureInfo.InvariantCulture) + " (" + Abates + " Kills / " + Mortes + " Deaths)");
            Console.WriteLine("Saldo atual: $" + Dinheiro);
            
            if (ArmaEquipada != null)
            {
                Console.WriteLine("Arma atual: " + ArmaEquipada.Nome);
            }
            else
            {
                Console.WriteLine("Arma atual: Nenhum equipamento comprado.");
            }
        }
    }

    class Partida
    {
        public string Mapa;
        public int RodadaAtual;
        public int RondasTR;
        public int RondasCT;

        public void RegistrarVitoriaRound(string ladoVencedor)
        {
            RodadaAtual++;
            if (ladoVencedor.ToUpper() == "TR")
            {
                RondasTR++;
            }
            else if (ladoVencedor.ToUpper() == "CT")
            {
                RondasCT++;
            }
        }

        public string VerVencedorPartida()
        {
            if (RondasTR >= 13)
            {
                return "Terroristas (TR) venceram a partida!";
            }
            else if (RondasCT >= 13)
            {
                return "Contra-Terroristas (CT) venceram a partida!";
            }
            return "Partida em andamento...";
        }

        public void ExibirPlacar()
        {
            Console.WriteLine("--- PLACAR CS2 (" + Mapa + ") ---");
            Console.WriteLine("TR " + RondasTR + " x " + RondasCT + " CT (Rodada: " + RodadaAtual + ")");
            Console.WriteLine("Status: " + VerVencedorPartida());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
  
            Arma ak47 = new Arma();
            Console.WriteLine("--- CADASTRO DE ARMA ---");
            Console.WriteLine("Digite o nome da arma:");
            ak47.Nome = Console.ReadLine();

            Console.WriteLine("Digite o tipo da arma (ex: Fuzil, Pistol, Sniper):");
            ak47.Tipo = Console.ReadLine();

            Console.WriteLine("Digite o preço da arma em $: ");
            ak47.Preco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o dano base da arma:");
            ak47.DanoBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            ak47.ExibirStatusArma();

            Console.WriteLine();
            Console.WriteLine("--- CADASTRO DO JOGADOR ---");
            Jogador p1 = new Jogador();

            Console.WriteLine("Digite o Nickname do jogador:");
            p1.Nickname = Console.ReadLine();

            Console.WriteLine("Digite o lado do jogador (TR ou CT):");
            p1.Lado = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de Abates (Kills):");
            p1.Abates = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de Mortes (Deaths):");
            p1.Mortes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o saldo inicial do jogador em $: ");
            p1.Dinheiro = int.Parse(Console.ReadLine());

            Console.WriteLine();

            bool comprou = p1.ComprarArma(ak47);
            if (comprou)
            {
                Console.WriteLine(">> Compra efetuada com sucesso!");
            }
            else
            {
                Console.WriteLine(">> Dinheiro insuficiente para comprar " + ak47.Nome);
            }

            Console.WriteLine();
            p1.ExibirStatusJogador();

            Console.WriteLine();
            Console.WriteLine("--- STATUS DA PARTIDA ---");
            Partida partida = new Partida();

            Console.WriteLine("Digite o nome do mapa (ex: Mirage, Inferno, Dust2):");
            partida.Mapa = Console.ReadLine();

            Console.WriteLine("Digite a pontuação atual dos TRs:");
            partida.RondasTR = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a pontuação atual dos CTs:");
            partida.RondasCT = int.Parse(Console.ReadLine());

            partida.RodadaAtual = partida.RondasTR + partida.RondasCT;

            Console.WriteLine();
            partida.ExibirPlacar();
        }
    }
}