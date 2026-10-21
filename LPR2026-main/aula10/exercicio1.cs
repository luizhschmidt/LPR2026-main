using System;

namespace aula10
{
    class Retangulo
    {
public double Largura;
public double Altura;

public double calcularArea()
        {
            return Largura * Altura;
        }

public double calcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

class Program
        {
            static void Main(string[] args)
            {
                Retangulo ret = new Retangulo();

                Console.WriteLine("Digite a Largura do Retangulo:");
                ret.Largura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Altura do Retangulo:");
                ret.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Area do Retangulo: " + ret.calcularArea());
                Console.WriteLine("Perimetro do Retangulo: " + ret.calcularPerimetro());
            }
        }

    }
}