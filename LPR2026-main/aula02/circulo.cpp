#include <iostream>
#include <iomanip> 

using namespace std;

int main() {

    const double PI = 3.14159;
    double raio;

    cout << "Digite o raio do círculo: ";
    cin >> raio;

    double area = PI * raio * raio;        

    cout << "A área do círculo é: " << fixed << setprecision(4) << area << endl;
    
    return 0;
}