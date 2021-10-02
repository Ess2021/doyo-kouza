#include <stdio.h>

int main() {
    int m, n;
    scanf("%d", &m);
    scanf("%d", &n);

    for (int i = m; i < n; i++) {
        if (i % 2 == 0) {
            printf("%d\n", i);
        }
    }

    /* 別解
    for (int i = m + (m % 2); i < n; i += 2) {
        printf("%d\n", i);
    }
    */

   return 0;
}