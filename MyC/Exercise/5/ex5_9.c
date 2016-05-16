/* Pierwsza wersja moja*/
/*#include<stdio.h>

int a;
void exe_seven(void);
void exe_eight(void);
int main(void)
{
	puts("\nChoose what you want to do:");
	puts("\n1.Exercise 7");
	puts("\n2.Exercise 8");
	scanf("%d",&a);
	if (a==1)
		exe_seven();
	else if (a==2)
		exe_eight();
	else
		puts("Bad choice");
	return 0;
}
void exe_seven(void)
{
	double a,b,l;
	puts("\nGive two numbers");
	puts("\nFirst:");
	scanf("%lf",&a);
	puts("\nSecond:");
	scanf("%lf",&b);
	l=a+b;
	printf("\nwynik : %f",l);
}
void exe_eight(void)
{
	int m,k;
	puts("\nGive a number 1:");
	scanf("%d",&m);
	puts("\nGive a number 2:");
	scanf("%d",&k);
	if (m!=0)
		printf("\nwynik : %d",m/k);
	else
		printf("We can not divide throught 0");
}

*/

/* Druga wersja zgodna bardziej z poleceniem*/
/*
#include<stdio.h>
double b,c,z,x;
int a;
double exe_seven(double b, double c);
double exe_eight(double z, double x);
int main(void)
{
	puts("\nChoose what you want to do:");
	puts("\n1.Exercise 7");
	puts("\n2.Exercise 8");
	scanf("%d",&a);
	
	if (a==1)
	{	
	puts("\nGive two numbers");
	puts("\nFirst:");
	scanf("%lf",&c);
	puts("\nSecond:");
	scanf("%lf",&b);
	printf("\nwynik : %f",exe_seven(b,c));
    }
	else if (a==2)
	{
	puts("\nGive two numbers");
	puts("\nFirst:");
	scanf("%lf",&z);
	puts("\nSecond:");
	scanf("%lf",&x);
	printf("\nwynik : %f",exe_eight(z,x));
	}
	else
		puts("Bad choice");
	return 0;
}
double exe_seven(double b, double c)
{
	double m;
	m=b+c;
	return m;
}
double exe_eight(double z, double x)
{
	if(x!=0)
	return z/x;
	else
	{
		puts("We can not divide throuht 0");
	return 0;
	}
}

/*Trzecia wersja ulepszona(najlepsza;))*/

#include<stdio.h>
int a;
void menu(double *s, double *y);
double exe_seven(double b, double c);
double exe_eight(double z, double x);

int main(void)
{
	do{
	puts("\n*************************Menu**************************************");
	puts("\nChoose what you want to do:");
	puts("\n1.Exercise 7");
	puts("\n2.Exercise 8");
	puts("\n0. Exit");
	puts("\n*******************************************************************");
	scanf("%d",&a);
	if (a==1)
	{	
	double p,o;
	menu(&p,&o);
	printf("\nwynik : %f",exe_seven(p,o));
    }
	else if (a==2)
	{
	double p,o;
	menu(&p,&o);
	printf("\nwynik : %f",exe_eight(p,o));
	}
	else if(a==0)
			puts("Goodbye");
	else
		puts("Bad choice, choose one more time:");
	}while(a!=0);
	return 0;
}
void menu(double *s, double *y)
{
	double w,g;
	puts("\nGive two numbers");
	puts("\nFirst:");
	scanf("%lf",&w);
	puts("\nSecond:");
	scanf("%lf",&g);
	*s=w;
	*y=g;
	
}
double exe_seven(double b, double c)
{
	double m;
	m=b+c;
	return m;
}
double exe_eight(double z, double x)
{
	if(x!=0)
	return z/x;
	else
	{
		puts("We can not divide throuht 0");
	return 0;
	}
}