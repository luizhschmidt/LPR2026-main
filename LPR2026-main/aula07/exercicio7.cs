using System;

class Exercicio6
{
    static void Main()
    {
        string[] cidades = { "Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo" };

        int[,] distancias = {
            { 0, 524, 521, 889 },   
            { 524, 0, 434, 586 },   
            { 521, 434, 0, 429 },   
            { 889, 586, 429, 0 }    
        };

        while (true)
        {
            Console.WriteLine("\n=== Consulta de Distâncias ===");
            Console.WriteLine("Cidades disponíveis:");
            for (int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i} - {cidades[i]}");
            }

            Console.Write("\nDigite o número da cidade de ORIGEM: ");
            int origem = LerOpcaoCidade(cidades.Length);

            Console.Write("Digite o número da cidade de DESTINO: ");
            int destino = LerOpcaoCidade(cidades.Length);

            if (origem == destino)
            {
                Console.WriteLine("\nOrigem e destino iguais informados. Encerrando programa.");
                break;
            }

            int distancia = distancias[origem, destino];
            Console.WriteLine($"\n> A distância entre {cidades[origem]} e {cidades[destino]} é de {distancia} km.");
            Console.WriteLine("\nPressione Enter para realizar uma nova consulta");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static int LerOpcaoCidade(int limite)
    {
        int escolha;
        while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 0 || escolha >= limite)
        {
            Console.Write($"Opção inválida. Digite um número entre 0 e {limite - 1}: ");
        }
        return escolha;
    }
}