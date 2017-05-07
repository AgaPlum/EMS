package com;

public class PermanentEmpBillCalculationImpl extends Employee implements BillCalculation{
	public double generateBillRate(Employee em)
	{
		return 200*8;
	}
}
