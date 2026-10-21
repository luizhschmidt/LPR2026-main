#include <iostream>
#include <vector>
using namespace std;

int main() {
    int numeros[10];
    vector<int> pares;
    vector<int> impares;

    cout << "Digite 10 numeros inteiros:\n";
    for (int i = 0; i < 10; i++) {
        cout << "Numero " << i + 1 << ": ";
        cin >> numeros[i];
 
        if (numeros[i] % 2 == 0) {
            pares.push_back(numeros[i]);
        } else {
            impares.push_back(numeros[i]);
        }
    }
    
    // Exibição dos resultados
    cout << "\nVetor de Pares\n";
    if (pares.empty()) {
        cout << "Nenhum numero par foi digitado.";
    } else {
        for (int p : pares) {
            cout << p << " ";
        }
    }
    
    cout << "\n Vetor de Impares \n";
    if (impares.empty()) {
        cout << "Nenhum numero impar foi digitado.";
    } else {
        for (int imp : impares) {
            cout << imp << " ";
        }
    }
    cout << endl;
    
    return 0;
}