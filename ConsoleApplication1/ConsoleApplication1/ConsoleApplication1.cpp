#include<stdio.h>


void main(void){
	char name[20] = "steven123", *p = name + 3;
	printf("%s %lx, %c %s\n", name, name, *p, p);

    return 0;
}

