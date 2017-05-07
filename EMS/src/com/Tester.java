package com;

import java.util.ArrayList;

public class Tester {

	public static void main(String[] args) {
		ArrayList<Employee> em = new ArrayList<Employee>();
		em.add(new Employee(101,"Name1",9,"contract","Project1"));
		em.add(new Employee(102,"Name2",64,"permanent","Project1"));
		em.add(new Employee(103,"Name3", 9,"contract","Project2"));
		em.add(new Employee(104,"Name4",10,"contract","Project2"));
		em.add(new Employee(105,"Name5",56,"permanent","Project1"));
		EmployeeManagement empl=new EmployeeManagement();

		System.out.println("1. The count of the Permanent Employee and Contract Employee.");
		System.out.println("Together: "+empl.getEmployeeCount(em));
		System.out.println("2. Display the List of Contract Employee.");
		System.out.println("List Contract Employee "+empl.getEmployeeList(em,EmployeeType.CONTRACT.toString().toLowerCase()));
		System.out.println("3. Display the List of Permanent Employee.");
		System.out.println("List Permanent Employee "+empl.getEmployeeList(em,EmployeeType.PERMANENT.toString().toLowerCase()));
		
		System.out.println("4. Calculate the Total Billing for a Project1 and also calculate the Total Billing for a Project 2.");
		System.out.println("Total Billing for Project1 "+empl.calculateProjectBill(em,"Project1"));
		System.out.println("Total Billing for Project2 "+empl.calculateProjectBill(em,"Project2"));
		System.out.println("5. Calculate the Total Billing for a Contract Employee and also calculate the Total Billing for a Permanent Employee.");
		try{
		double c=0;
		double p=0;
		String con="contract";
		String per="permanent";
		for(int i=0;i<em.size();i++)
		{
			if(con.equals(em.get(i).getEmployeeType().toString().toLowerCase()))
			{
				c=c+empl.billCalcContractEmployee(em.get(i),i);
			}
			else
			{
				p=p+empl.billCalcPermanentEmployee(em.get(i),i);
			}		
		}
		System.out.println("Total Billing for a Contract Employee: "+c);
		System.out.println("Calculate the Total Billing for a Permanent Employee " +p);
		}
		catch(EmployeeTypeMismatchException message)
		{
			message.printStackTrace();
		}
	}

}
