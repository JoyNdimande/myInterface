using System;

interface IEmployees
{
    string GetEmployeeName();
    int GetEmployeeID();
    double GetSalary();
}

interface IEDepartment
{
    string GetDepartmentName();
    string GetHOP();
}

class Employees : IEmployees, IEDepartment   //Inheriting both
{
    private string employeeName;
    private int employeeID;
    private double salary;
    private string departmentName;
    private string HOP;
    public Employees(string name, int id, double salary, string department, string hop)
    {
        this.employeeName = name;
        this.employeeID = id;
        this.salary = salary;
        this.departmentName = department;
        this.HOP = hop;
    }
    public string GetEmployeeName()
    {
        return employeeName;
    }
    public int GetEmployeeID()
    {
        return employeeID;
    }
    public double GetSalary()
    {
        return salary;
    }
    public string GetDepartmentName()
    {
        return departmentName;
    }
    public string GetHOP()
    {
        return HOP;
    }

    double IEmployees.GetSalary()
    {
        throw new NotImplementedException();
    }
}