using System;

class Exercicio7
{
    static void Main()
    {
        int[,] matrizA = new int[3, 3];
        int[,] matrizB = new int[3, 3];
        int[,] matrizC = new int[3, 3]; // Resultado de A * B

        Console.WriteLine("Leitura da Matriz A (3x3)");
        PreencherMatriz(matrizA);

        Console.WriteLine("\n Leitura da Matriz B (3x3)");
        PreencherMatriz(matrizB);

        // Algoritmo de multiplicação de matrizes
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizC[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    matrizC[i, j] += matrizA[i, k] * matrizB[k, j];
                }
            }
        }

        // Resultados
        Console.WriteLine("\nMatriz A:");
        ExibirMatriz(matrizA);

        Console.WriteLine("\nMatriz B:");
        ExibirMatriz(matrizB);

        Console.WriteLine("\nMatriz Resultante C (A * B):");
        ExibirMatriz(matrizC);
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Posição [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.Write("Inválido. Digite um número inteiro: ");
                }
            }
        }
    }

    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(6) + " ");
            }
            Console.WriteLine();
        }
    }
}