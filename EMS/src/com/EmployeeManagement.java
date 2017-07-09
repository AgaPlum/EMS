package com;
import java.util.ArrayList;

public class EmployeeManagement extends Employee{

	public static int getEmployeeCount(ArrayList<Employee> em)
	{
		int c=0;
		int p=0;
		for(Employee e:em)
		{
			if (e.getEmployeeType()==EmployeeType.CONTRACT)
				{
					c++;
				}
			else if(e.getEmployeeType()==EmployeeType.PERMANENT)
				{
					p++;
				}
		}
		System.out.println("Contract workers: "+c);
		System.out.println("Permanent workers: "+p);
		return c+p;
	}
	public static ArrayList<Employee> getEmployeeList(ArrayList<Employee> em, String s)
	{
		ArrayList<Employee> l= new ArrayList<Employee>();
		for(int i=0;i<em.size();i++)
		{
			if(s.equals(em.get(i).getEmployeeType().toString().toLowerCase()))
			{
				l.add(em.get(i));
			}
		}
		
		return  l;
	}
	public static double billCalcContractEmployee(Employee e, int s) throws EmployeeTypeMismatchException
	{
		//double z=0;
		ContractEmpBillCalculationImpl c=new ContractEmpBillCalculationImpl();
		if(e.getEmployeeType().toString().toLowerCase().equals("contract"))
		{
			return c.generateBillRate(e);
		}
		else
		{
			throw new EmployeeTypeMismatchException("This is not contract");
		}
	}
	public static double billCalcPermanentEmployee(Employee e, int s) throws EmployeeTypeMismatchException
	{
		//double z=0;
		PermanentEmpBillCalculationImpl c=new PermanentEmpBillCalculationImpl();
		if(e.getEmployeeType().toString().toLowerCase().equals("permanent"))
		{
			return c.generateBillRate(e);
		}
		else
		{
			throw new EmployeeTypeMismatchException("This is not permanent");
		}
		
	}
	public static double calculateProjectBill(ArrayList<Employee> em, String s)
	{
		double z=0;
		s=s.toLowerCase();
		for(int i=0;i<em.size();i++)
		{
		if(s.equals(em.get(i).getProjectName().toLowerCase()))
		{
			z=z+em.get(i).getNoOfHoursWorked();
		}
		}
		return z;
	}
	
}
