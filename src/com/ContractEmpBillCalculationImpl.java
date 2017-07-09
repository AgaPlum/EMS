package com;

public class ContractEmpBillCalculationImpl extends Employee implements BillCalculation{

	public double generateBillRate(Employee em)
	{
		return 		20*em.getNoOfHoursWorked();
	}
}
