import java.util.Scanner;
public class Functions {
	public static char menu()
	{
		char a;
		System.out.println("-------------------------------------------------------------------");
		System.out.println("Menu");
		System.out.println("1.Operation on array");
		System.out.println("2.Operation on string");
		System.out.println("3.Operation on case");
		System.out.println("4.Close program");
		System.out.println("-------------------------------------------------------------------");
		Scanner ret = new Scanner(System.in);
		a = ret.next().charAt(0);
		return a;
	}
	public static void arrays()
	{
		int [] tab= new int [8];
		System.out.println("Give 8 numbers");
		Scanner rnum = new Scanner(System.in);
		for (int i=0;i<8;i++)
		{
			int k = rnum.nextInt();
			tab[i]=k;
		}
		System.out.println("The fifth number was:"+tab[5]);
	}
	public static void strings()
	{
		char[] tabs = new char [8];
		Scanner rr =new Scanner(System.in);
		System.out.println("Choose word which have 8 letters and write them but singly");
		for (int j=0;j<8;j++)
		{
			char st=rr.next().charAt(0);
			tabs[j]=st;
		}
	      String whatstr = new String(tabs);  
	      System.out.println(whatstr);
	      int len = whatstr.length();
	      System.out.println( "String Length is : " + len );
	      System.out.println("This word: " + whatstr + " is briliant");
		
	}
	public static void casse()
	{
		System.out.println("Choose number which represents your " +
				"lucky day and you will now what will happend in this day:\n1.Monday" +
				"\n2.Tuesday \n3.Wednesday \n4.Thursday \n5.Friday \n6.Saturday \n7.Sunday");
		Scanner ns = new Scanner(System.in);
		int number = ns.nextInt();
		switch(number)
		{
		case 1:
			System.out.println("Somebody will help you a lot today.");
			break;
		case 2:
			System.out.println("Someone will invite you for a dinner");
			break;
		case 3:
			System.out.println("This will be your best day ever.");
			break;
		case 4:
			System.out.println("You will be looking amazing this day.");
			break;
		case 5:
			System.out.println("It is almost weekend, party time;)");
			break;
		case 6:
			System.out.println("You will go to cinema with your friends.");
			break;
		case 7:
			System.out.println("Funday:D you will have lots of fun;)");
			break;
		default:
			System.out.println("Nothing will happened because you didnt choose correct.");	
		}
	}
	public static void main(String[]args)
	{
		char z;
		do{
		z = menu();
		if(z =='1')
		{
			arrays();
		}
		else if(z=='2')
		{
			strings();
		}
		else if(z=='3')
		{
			casse();
		}
		else if(z=='4')
		{
			System.out.println("Goodby");
		}
		else
		{
			System.out.println("Choose one more time");
		}
		}while(z!='4');
	}
}
