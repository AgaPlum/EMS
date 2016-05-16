/*Program ma za zadanie pobrać dwie dartości podane przez użytkownika, a nastepnie po wyborze dzialania
jakie ma zostac wykonane podaje wynik. Uzytkownic wybiera dzialanie przez podanie numeru dzialania 
jakie sa podane w menu*/
#include <stdio.h>
//zmienne
int a,b,c,d;
int dodawanie(int a,int b);
int odejmowanie(int a,int b);
int mnozenie(int a,int b);
int dzielenie(int a,int b);
//main
int main(void)
{
	printf("Podaj pierwsza liczbe:");
	scanf("%d",&a);
	printf("Podaj druga liczbe:");
	scanf("%d",&b);
	printf("Menu:\n 1.Dodawanie \n 2.Odejmowanie \n 3.Mnozenie \n 4.Dzielenie");
	printf("\n Podaj numer działania:");
	scanf("%d",&d);
		if (d==1)
		{
			printf("Wynik działania to: %d",dodawanie(a,b));
		}
		
		if (d==2)
		{
			printf("Wynik działania to: %d",odejmowanie(a,b));
		}
		if (d==3)
		{
			printf("Wynik działania to: %d",mnozenie(a,b));
		}
		if (d==4)
		{
			printf("Wynik działania to: %d",dzielenie(a,b));
		}
	return 0;
}
int dodawanie(int a,int b)
{
	c=a+b;
	return c;
}
int odejmowanie(int a,int b)
{
	c=a-b;
	return c;
}
int mnozenie(int a, int b)
{
	c=a*b;
	return c;
}
int dzielenie(int a, int b)
{
	c=a/b;
	return c;
}