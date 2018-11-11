#include <stdio.h>
#include <stdlib.h>

int main()
{
    int array[3] ={0,1,2};
    int *ptr = array;

    printf("%d", *(ptr+(2*sizeof(int))));
    printf("%d", *(ptr+8));
    printf("%d", sizeof(int));

    return 0;
}
