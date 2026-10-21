using System;

class Exercicio5
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int soma = 0;

        Console.WriteLine(" Digite os elementos da matriz 3x3");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Posição [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.Write("Entrada inválida. Digite um número inteiro: ");
                }
                soma += matriz[i, j];
            }
        }

        Console.WriteLine("\n Matriz Digitada");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(5) + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}");
    }
}