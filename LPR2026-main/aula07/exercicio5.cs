using System;
using System.Collections.Generic;

class Exercicio4
{
    struct Aluno
    {
        public string Nome;
        public double Nota;
        public string Situacao;
    }

    static void Main()
    {
        List<Aluno> turma = new List<Aluno>();
        string continuar = "S";
        
        double somaNotas = 0;
        int aprovados = 0;
        int recuperacao = 0;
        int reprovados = 0;

        Console.WriteLine(" Cadastro de Notas da Turma-");

        while (continuar.ToUpper() == "S")
        {
            Aluno aluno;
            Console.Write("\nDigite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write($"Digite a nota de {aluno.Nome} (0 a 100): ");
            while (!double.TryParse(Console.ReadLine(), out aluno.Nota) || aluno.Nota < 0 || aluno.Nota > 100)
            {
                Console.Write("Nota inválida. Digite um valor entre 0 e 100: ");
            }

            if (aluno.Nota >= 70)
            {
                aluno.Situacao = "Aprovado";
                aprovados++;
            }
            else if (aluno.Nota >= 50)
            {
                aluno.Situacao = "Recuperação";
                recuperacao++;
            }
            else
            {
                aluno.Situacao = "Reprovado";
                reprovados++;
            }

            somaNotas += aluno.Nota;
            turma.Add(aluno);

            Console.Write("Deseja cadastrar outro aluno? (S/N): ");
            continuar = Console.ReadLine();
        }

        // Exibição do Relatório
        Console.WriteLine("\n RELATÓRIO FINAL");
        foreach (var aluno in turma)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Nota:F1} - {aluno.Situacao}");
        }
        
        double media = turma.Count > 0 ? somaNotas / turma.Count : 0;
        
        Console.WriteLine($"Aprovados: {aprovados}");
        Console.WriteLine($"Recuperação: {recuperacao}");
        Console.WriteLine($"Reprovados: {reprovados}");
        Console.WriteLine($"Média da turma: {media:F1}");
    }
}