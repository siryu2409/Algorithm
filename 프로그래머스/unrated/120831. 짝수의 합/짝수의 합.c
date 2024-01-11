#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    if(n % 2 ==0)
        return (n * (n / 2))/2 + n/2;
    else
        return solution(n-1);
}