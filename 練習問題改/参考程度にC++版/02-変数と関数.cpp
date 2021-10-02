#include <iostream>

using namespace std;

double ave(int a, int b, int c) {
    int _sum = a + b + c;
    double _ave = _sum / 3;
    return _ave;
}

int main() {
    int a, b, c;

    cin >> a;
    cin >> b;
    cin >> c;

    double res = ave(a, b, c);
    cout << res << endl;

    return 0;
}