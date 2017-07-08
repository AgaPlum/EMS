package com;

public class Employee {
	
private int employeeID;
private String employeeName;
private int noOfHoursWorked;
private EmployeeType employeeType;
private String projectName;

public Employee(int employeeID, String employeeName, int noOfHoursWorked,
		String employeeType, String projectName) {
	this.employeeID = employeeID;
	this.employeeName = employeeName;
	this.noOfHoursWorked = noOfHoursWorked;
	if(employeeType.equals(EmployeeType.CONTRACT.toString().toLowerCase()))
	{
		setEmployeeType(EmployeeType.CONTRACT);
	}
	else if (employeeType.equals(EmployeeType.PERMANENT.toString().toLowerCase()))
	{
		setEmployeeType(EmployeeType.PERMANENT);
	}
	//this.employeeType = employeeType;
	if(projectName.toLowerCase().equals("project1"))
	{
		setProjectName(projectName);
	}
	else if(projectName.toLowerCase().equals("project2"))
	{
		setProjectName(projectName);
	}
}
public Employee() 
{
	super();
}

public String toString() {
	return "Employee [employeeID=" + employeeID + ", employeeName="
			+ employeeName + ", noOfHoursWorked=" + noOfHoursWorked
			+ ", employeeType=" + employeeType + ", projectName=" + projectName
			+ "]";
}
public int getEmployeeID() {
	return employeeID;
}
public void setEmployeeID(int employeeID) {
	this.employeeID = employeeID;
}
public String getEmployeeName() {
	return employeeName;
}
public void setEmployeeName(String employeeName) {
	this.employeeName = employeeName;
}
public int getNoOfHoursWorked() {
	return noOfHoursWorked;
}
public void setNoOfHoursWorked(int noOfHoursWorked) {
	this.noOfHoursWorked = noOfHoursWorked;
}
public EmployeeType getEmployeeType() {
	return employeeType;
}
public void setEmployeeType(EmployeeType employeeType) {
	this.employeeType = employeeType;
}
public String getProjectName() {
	return projectName;
}
public void setProjectName(String projectName) {
	this.projectName = projectName;
}

}
