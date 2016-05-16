#include <stdio.h>

void display_line(void);

int main(void)
{
display_line();
printf("\n Teach Yourself!\n");
display_line();
return 0;
}

void display_line(void)
{
int counter;
for(counter=0;counter<30;counter++)
		printf("*");

}