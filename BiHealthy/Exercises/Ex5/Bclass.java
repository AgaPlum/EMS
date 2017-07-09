
public class Bclass {

	public static void main(String[] args)
	{
		Animals an[]=new Animals[3];
		an[0]=new Mammals();
		an[1]=new Amphibians();
		for(int i=0; i<2;i++)
		{
			an[i].info();
		}
		Animals ani=new Animals();
		Mammals ma=new Mammals();
		ma.test(ani);
	}
}
