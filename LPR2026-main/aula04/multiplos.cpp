#include <iostream>

using namespace std;

int main() {
    int A, B;

    // Lendo os dois valores inteiros
    cin >> A >> B;

    // Verificamos se A é múltiplo de B OU se B é múltiplo de A
    // O operador % retorna 0 se a divisão for exata
    if (A % B == 0 || B % A == 0) {
        cout << "Sao Multiplos" << endl;
    } else {
        cout << "Nao sao Multiplos" << endl;
    }

    return 0;
}