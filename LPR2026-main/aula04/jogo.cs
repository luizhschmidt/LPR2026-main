using System;

class Program {
    static void Main() {
        Console.WriteLine("Escolha sua classe:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueiro");
        Console.WriteLine("4 - Ladino");
        Console.Write("\nDigite o número da classe: ");

        string escolha = Console.ReadLine();

        Console.WriteLine("\nHabilidades Especiais:");
        
        switch (escolha) {
            case "1":
                Console.WriteLine("Classe: Guerreiro");
                Console.WriteLine("- Investida Furiosa: Avança contra o inimigo com o escudo.");
                Console.WriteLine("- Brado de Guerra: Aumenta a defesa dos aliados próximos.");
                break;
            case "2":
                Console.WriteLine("Classe: Mago");
                Console.WriteLine("- Bola de Fogo: Dano em área com elemento fogo.");
                Console.WriteLine("- Escudo Arcano: Absorve uma quantidade de dano mágico.");
                break;
            case "3":
                Console.WriteLine("Classe: Arqueiro");
                Console.WriteLine("- Chuva de Flechas: Atinge múltiplos alvos simultaneamente.");
                Console.WriteLine("- Olhar de Águia: Aumenta a precisão e o alcance crítico.");
                break;
            case "4":
                Console.WriteLine("Classe: Ladino");
                Console.WriteLine("- Passo das Sombras: Torna-se invisível por 5 segundos.");
                Console.WriteLine("- Golpe Baixo: Causa envenenamento e reduz a velocidade do alvo.");
                break;
            default:
                Console.WriteLine("Classe inválida! Tente novamente e escolha um número de 1 a 4.");
                break;
        }
    }
}