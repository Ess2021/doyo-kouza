#include <stdio.h>

double Ave (int a, int b, int c) {
    int _sum = a + b + c;
    double _ave = _sum / 3;
    return _ave;
}

int main() {
    int a, b, c;
    scanf("%d", &a);
    scanf("%d", &b);
    scanf("%d", &c);
    double res = Ave(a, b, c);
    printf("%f\n", res);

    return 0;
}