#include<stdio.h>

int e;
void prefix(void);
void mod_oper(void);
void rel_exp(void);
void rel_oper(void);

int main()
{
	do
	{
	printf("\n********************************************");
	printf("\nChoose what you want to check:");
	printf("\n1. How works x++ and ++x.\n");
	printf("\n2. How works modulus operator.\n");
	printf("\n3. How works relational expressions\n");
	printf("\n4. How works relational operator.\n");
	printf("\nEnter 0 if you want to exit.\n");
	scanf("%d",&e);
	if(e==1)
		prefix();
	else if(e==2)
		mod_oper();
	else if(e==3)
		rel_exp();
	else if(e==4)
		rel_oper();
	else
	{
		if(e==0)
			printf("Thanks for everything and have a beautifull day :D :D");
		else
		printf("You choose wrong one number start one more time.");
	}
	}
	while(e!=0);
	return 0;
}
//first method
void prefix(void)
{
	printf("\n*****************Method 1***************************");
	int a,b;
	a=b=0;
	printf("\nCount down");
	printf("\n%d  %d",a--,--b);
	printf("\n%d  %d",a--,--b);
	printf("\n Aktualne wartosci %d  %d",a,b);
	printf("\nCount up=");
	printf("\n%d  %d",a++,++b);
	printf("\n%d  %d",a++,b++);
	printf("\n Aktualne wartosci %d  %d",a,b);
}
//second method
void mod_oper(void)
{
	printf("\n*****************Method 2***************************");
	const int sec_per_min=60;
	const int sec_per_hour=3600;
	int sec,hours,minutes,min_left,sec_left;
	printf("\nEnter number of seconds(<65000)\n");
	scanf("%d",&sec);
	hours=sec/sec_per_hour;
	minutes=sec/sec_per_min;
	min_left=minutes%sec/sec_per_min;
	sec_left=sec%sec_per_min;
	printf("%d seconds is equal to",sec);
	printf("%d h, %d m, %d s",hours,min_left,sec_left);
}
//third method
void rel_exp(void)
{
printf("\n*****************Method 3***************************");
int a;
a=(5==5);
printf("\na = (5==5)\n a=%d",a);	
a=(5!=5);
printf("\na=(5!=5)\n a=%d",a);
a=(12==12)+(5!=1);
printf("\na=(12==12)+(5!=1)\n a=%d",a);
}
//fourth method
void rel_oper(void)
{
	printf("\n*****************Method 4***************************");
	const int curent_year = 2015;
	int birt,age;
	printf("\nEnter the year you were born (YYYY):\n");
	scanf("%d",&birt);
	if(birt%4==0)
		printf("You were born in leap year");
	if(birt%4!=0)
		printf("You were not born in leap year");
	age=curent_year-birt;
	printf("\nYou have %d",age);
	if(age<18)
	{
		printf("\nYou are young");
		printf("\nYou can't drink");
	}
	else if(age>=65)
		printf("\nYou are a senior");
	else
	{
		printf("\nYou are adult");
		if(age>=21)
		printf("\nYou can drink");
		else
			printf("\nYou can't drink");
	}
	
}