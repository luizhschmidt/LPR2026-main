using System;

class Program {
    static void Main() {
    
        Console.Write("Digite um número inteiro: ");
    
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0) {
            Console.WriteLine("PAR");
        }
        else {
            Console.WriteLine("IMPAR");
        }
    }
}