#include<stdio.h>
double avar(float a,float b,float c, float d, float e);
int main(void)
{
	float a,b,c,d,e;
	puts("Give 5 numbers use , to separate:");
	scanf("%f,%f,%f,%f,%f",&a,&b,&c,&d,&e);
	double z = avar(a,b,c,d,e);
	printf("Wynik %f",z);
	return 0;
}
double avar(float a,float b,float c, float d, float e)
{
	double z=(a+b+c+d+e)/5;
	return z;
}