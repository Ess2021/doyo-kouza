#include <stdio.h>

int main() {
    int n;
    scanf("%d", &n);

    if (n < 20) {
        printf("あなたは未成年です\n");
    } else {
        printf("あなたは成人です\n");
    }

    return 0;
}