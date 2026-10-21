using System;

namespace aula10
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double CalcularImposto()
        {
            if (SalarioBruto <= 2000.0)
            {
                return SalarioBruto * 0.10;
            }
            else if (SalarioBruto <= 3000.0)
            {
                return SalarioBruto * 0.15;
            }
            else
            {
                return SalarioBruto * 0.20;
            }
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Funcionário: " + Nome + ", Salário líquido: R$ " + SalarioLiquido());
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100.0);
            Imposto = CalcularImposto();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário:");
            func.Nome = Console.ReadLine(); 

            Console.WriteLine("Digite o salário bruto do funcionário:");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            func.Imposto = func.CalcularImposto();

            Console.WriteLine();
            func.MostrarDados();

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            func.MostrarDados();
        }
    }
}