#include <iostream>
using namespace std;

int main() {
    int vetor[5];
    
    // Leitura dos números
    cout << "Digite 5 numeros inteiros:\n";
    for (int i = 0; i < 5; i++) {
        cout << "Posicao [" << i << "]: ";
        cin >> vetor[i];
    }
    
    int maior = vetor[0];
    int posicaoMaior = 0;

    for (int i = 1; i < 5; i++) {
        if (vetor[i] > maior) {
            maior = vetor[i];
            posicaoMaior = i;
        }
    }
    cout << "\n Resultados-\n";
    cout << "Numeros digitados: ";
    for (int i = 0; i < 5; i++) {
        cout << vetor[i] << " ";
    }
    cout << "\nMaior valor: " << maior;
    cout << "\nPosicao do maior valor: " << posicaoMaior << endl;
    
    return 0;
}