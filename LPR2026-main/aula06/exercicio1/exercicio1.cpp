#include <iostream>
using namespace std;

int inverterNumero(int num) {
    int reverso = 0;

    while (num != 0) {
        int digito = num % 10;       // pega o último dígito
        reverso = reverso * 10 + digito; // adiciona no reverso
        num = num / 10;              // remove o último dígito
    }

    return reverso;
}
int main() {
    int numero;

    cout << "Digite um numero: ";
    cin >> numero;

    cout << "Numero invertido: " << inverterNumero(numero);

    return 0;
}