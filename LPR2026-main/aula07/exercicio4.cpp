#include <iostream>
#include <string>
#include <vector>
using namespace std;

string ClassificarAluno(int nota) {
    if (nota >= 70) {
        return "Aprovado";
    } else if (nota >= 50) {
        return "Recuperacao";
    } else {
        return "Reprovado";
    }
}

int main() {
    string nomes[10];
    int notas[10];
    
    cout << "=== Cadastro de Alunos e Notas ===\n";
    for (int i = 0; i < 10; i++) {
        cout << "\nAluno " << i + 1 << ":\n";
        cout << "Nome: ";
        cin >> nomes[i];

        do {
            cout << "Nota (0 a 100): ";
            cin >> notas[i];
            if (notas[i] < 0 || notas[i] > 100) {
                cout << "Nota invalida! Digite um valor entre 0 e 100.\n";
            }
        } while (notas[i] < 0 || notas[i] > 100);
    }
o
    cout << " RELATORIO DE NOTA\n";
    
    for (int i = 0; i < 10; i++) {
        cout << "Aluno: " << nomes[i] 
             << " | Nota: " << notas[i] 
             << " | Situacao: " << ClassificarAluno(notas[i]) << endl;
    }
    
    return 0;
}