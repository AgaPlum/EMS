/*
public class ETwo {
	private int day;
	private int month;
	private int year;
private int money =5000;
	public void mtab(int tab[][])
	{
		for(int i=0;i<tab.length;i++)
		{
			for(int j=0;j<tab[i].length;j++)
			{
				System.out.print(tab[i][j] + "\t");
			}
			System.out.println();
		}
		
	}
	public void num(int...number)
	{
		int a=0;
		for(int z=0;z<number.length;z++)
		{
			a+=number[z];
		}
		System.out.println("The score is:"+a);
	}
	public int ver(int money)
	{
		this.money= 1000;
		return this.money;
	}
	public void mon()
	{
		System.out.println("Do you have this money " +money+ " or you have this "+ ver(money));
	}
	//constructor
	//-------------------------------
	public ETwo()
	{
		this(0,0,0);
	}
	public ETwo(int d)
	{
		this(d,0,0);
	}
	public ETwo(int d, int m)
	{
		this(d,m,0);
	}
	public ETwo(int d, int m, int y)
	{
		setDate(d,m,y);
	}
	public void setDate(int d, int m, int y)
	{
		setDay(d);
		setMonth(m);
		setYear(y);
	}
	public void setDay(int d)
	{
		day = ((d>=1&&d<=30)?d:0);
	}
	public void setMonth(int m)
	{
		month = ((m>=1&&m<=12)?m:0);
	}
	public void setYear(int y)
	{
		year = ((y>=1930&&y<=2016)?y:0);
	}
	public int getDay()
	{
		return day;
	}
	public int getMonth()
	{
		return month;
	}
	public int getYear()
	{
		return year;
	}
	public String dateWeWant()
	{
		return String.format("%02d/%02d/%04d",getDay(),getMonth(),getYear());
	}
}
*/