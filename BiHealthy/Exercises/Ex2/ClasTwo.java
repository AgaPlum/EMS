/*import java.util.Random;
import java.util.Scanner;

public class ClasTwo {
private Scanner s = new Scanner(System.in);
private int a;
	public void test1()
	{
		System.out.println("Give your age:");
		a = s.nextInt();
		System.out.println(a > 18 ? "You are adult":"You are a child");
	}
	public void test2()
	{ 
		int d=0;
		Random r=new Random();
		for(int i=0;i<10;i++)
		{
			d=r.nextInt(101);
			System.out.println(d + " ");
		}
		System.out.println("Your lucky number is: "+d);
	}
	public void test3()
	{
		System.out.println("You have: "+ a);
		System.out.println("How old is your Mother");
		int m=s.nextInt();
		System.out.println("How old is your Father");
		int f=s.nextInt();
		System.out.println("How old is your Brother/Sister");
		int bs=s.nextInt();
		int sum=0;
		int fs[]={a,m,f,bs};
		for(int j=0;j<fs.length;j++)
		{
			sum+=fs[j];
		}
		System.out.println("Together your family have :"+ sum +" years");
	}
	public void test4(int tab[])
	{
		for(int po=0;po<tab.length;po++)
		{
			System.out.println(tab[po]);
		}
	}
}
*/