#include <stdio.h>

void menu(void);
void p_pier(void);
void p_druga(void);
void p_trzec(void);
int main(void)
{
	menu();
	return 0;
}
void menu(void)
{
	char a;
do{
	puts("*****************************************");
	puts("\nChoose what loop you want to test:");
	puts("\n1. Test loop For");
	puts("\n2. Test loop while");
	puts("\n3. Test loop do..while");
	puts("\n Choose e or E if you want to exit");
	scanf("%c",&a);
	if(a=='1')
		p_pier();
	else if(a=='2')
		p_druga();
	else if(a=='3')
		p_trzec();
	else
		puts("Error one more time choose");
}while(a!='e');

}
void p_pier(void)
{
puts("pier");
}
void p_druga(void)
{
puts("dru");
}
void p_trzec(void)
{
puts("trzeci");
}