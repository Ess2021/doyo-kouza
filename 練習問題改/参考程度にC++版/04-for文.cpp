#include <iostream>

using namespace std;

int main() {
    int m, n;
    cin >> m;
    cin >> n;

    for (int i = m; i < n; i++) {
        if (i % 2 == 0) {
            cout << i << endl;
        }
    }

    /* 別解
    for (int i = m + (m % 2); i < n; i++) {
        cout << i << endl;
    }
    */

    return 0;
}