#include <iostream>
using namespace std;

float mediaPares(int quantidade) {
    int numero, contador = 0, soma = 0, i = 0;

    while (i < quantidade) {
        cout << "Digite o numero " << i + 1 << ": ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }

        i++;
    }

    if (contador == 0) {
        return 0; 
    }

    return (float)soma / contador;
}

int somaImparesMultiplos3() {
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    return soma;
}

int somaDigitosQuadrado(int numero) {
    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    return soma;
}

int main() {
    int opcao;

    do {
        cout << "\n===== MENU =====\n";
        cout << "1 - Media dos numeros pares\n";
        cout << "2 - Soma dos impares multiplos de 3 (50 a 500)\n";
        cout << "3 - Soma dos digitos do quadrado\n";
        cout << "0 - Sair\n";
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                int qtd;
                cout << "Quantos numeros deseja digitar? ";
                cin >> qtd;

                float media = mediaPares(qtd);
                cout << "Media dos pares: " << media << endl;
                break;
            }

            case 2: {
                int resultado = somaImparesMultiplos3();
                cout << "Soma: " << resultado << endl;
                break;
            }

            case 3: {
                int num;
                cout << "Digite um numero: ";
                cin >> num;

                int resultado = somaDigitosQuadrado(num);
                cout << "Soma dos digitos do quadrado: " << resultado << endl;
                break;
            }

            case 0:
                cout << "Encerrando...\n";
                break;

            default:
                cout << "Opcao invalida!\n";
        }

    } while (opcao != 0);

    return 0;
}