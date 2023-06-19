#include <stdio.h>

void fn(int *c, int *d){
    int temp = 0;
    temp = *c;     // temp = 10
    *c = *d;       // *c = 5
    *d = temp;     // *d = 10
}

void main(){
    int a = 10;
    int b = 5;
    fn(&a, &b);     // 1. &a = *c,  &b = *d
    printf("%d %d\n" , a, b);   // 5 10 이 정답
}