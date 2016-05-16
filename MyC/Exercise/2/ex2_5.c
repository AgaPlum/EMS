#include <stdio.h>
#include <string.h>

int main(void)
{ 	FILE *fd;
	char buffer[256];
	printf("Enter your name and pres [Enter]:\n");
	//fgets( buffer , 256, fd);//??????
	gets( buffer);
	printf("\n Your name is has %d characters and it is %c",strlen( buffer ));
return 0;
}