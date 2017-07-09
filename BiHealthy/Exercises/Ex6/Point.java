import java.util.Scanner;
public class Point {
	public static Scanner sc= new Scanner(System.in);
public static void main(String[] args)
	{
		System.out.println("Give the x:");
		int x=sc.nextInt();
		System.out.println("Give the y:");
		int y=sc.nextInt();
		System.out.println("Give the z:");
		int z=sc.nextInt();
		Point2D p2=new Point2D(x,y);
		System.out.println("The 2D demension where x:"+p2.x+" and y:" +p2.y);
		Point3D p3=new Point3D(x,y,z);
		System.out.println("The 3D demension where x:"+p3.x+" y:"+p3.y+" and z:"+p3.z);
	}
}
