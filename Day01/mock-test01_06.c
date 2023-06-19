#include <stdio.h>

int add(int i, int j){
    return i + j;
}

int sub(int i, int j){
    return i - j;
}

void main(){
    int (*pf)(int, int);

    pf = add;
    printf("%d", pf(5 ,4));

    pf = sub;
    printf("%d", pf(5, 4));

}
