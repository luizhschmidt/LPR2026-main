using System;
using System.Globalization;

namespace aula10
{
    class Aluno
    {
        public string Matricula;
        public string Nome;
        public double NotaProva1;
        public double NotaProva2;
        public double NotaTrabalho;

        public double Media()
        {
            return ((NotaProva1 * 2.5) + (NotaProva2 * 2.5) + (NotaTrabalho * 2.0)) / 7.0;
        }

        public double Final()
        {
            double mediaAtual = Media();

            if (mediaAtual >= 60.0)
            {
                return 0.0;
            }
            else
            {
                return 60.0 - mediaAtual;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite a matrícula do aluno:");
            aluno.Matricula = Console.ReadLine();

            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a nota da prova 1:");
            aluno.NotaProva1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota da prova 2:");
            aluno.NotaProva2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota do trabalho:");
            aluno.NotaTrabalho = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            double mediaFinal = aluno.Media();
            Console.WriteLine("Média do aluno: " + mediaFinal.ToString("F2", CultureInfo.InvariantCulture));

            double precisaFinal = aluno.Final();

            if (precisaFinal == 0.0)
            {
                Console.WriteLine("Aluno aprovado! Não precisa de prova final.");
            }
            else
            {
                Console.WriteLine("Aluno ficou de final. Precisa tirar no mínimo: " + precisaFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}