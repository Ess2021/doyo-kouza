#include <iostream>

using namespace std;

int main() {
    int n;
    cin >> n;

    if (n < 20) {
        cout << "あなたは未成年です" << endl;
    } else {
        cout << "あなたは成人です" << endl;
    }

    return 0;
}