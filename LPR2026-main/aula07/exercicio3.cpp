#include <iostream>
#include <vector>
using namespace std;

int main() {
    int numeros[10];
    
    cout << "Digite 10 numeros inteiros:\n";
    for (int i = 0; i < 10; i++) {
        cout << "Posicao [" << i << "]: ";
        cin >> numeros[i];
    }
    
    int busca;
    cout << "\nDigite um numero para pesquisar no vetor: ";
    cin >> busca;
    
    int ocorrencias = 0;
    vector<int> posicoesEncontradas;

    for (int i = 0; i < 10; i++) {
        if (numeros[i] == busca) {
            ocorrencias++;
            posicoesEncontradas.push_back(i);
        }
    }

    cout << "\n Resultado da Busca\n";
    if (ocorrencias > 0) {
        cout << "O numero " << busca << " foi encontrado " << ocorrencias << " vez(es).\n";
        cout << "Posicao(oes) em que aparece: ";
        for (int pos : posicoesEncontradas) {
            cout << "[" << pos << "] ";
        }
        cout << endl;
    } else {
        cout << "O numero " << busca << " nao foi encontrado no vetor." << endl;
    }
    
    return 0;
}