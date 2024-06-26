using System;

public class Employee
{
    private static int lastEmpNo = 0;

    public int EmpNo { get; private set; }
    public string Name { get; set; }
    public int Id { get; set; }
    public int Experience { get; set; }

    
    public Employee()
    {
        EmpNo = ++lastEmpNo;
    }

    
    public Employee(string name) : this()
    {
        Name = name;
    }
    public Employee(string name, int id) : this(name)
    {
        Id = id;
    }   
    public Employee(string name, int id, int experience) : this(name, id)
    {
        Experience = experience;
    }
}

public class Program
{
    public static void Main()
    {
        Employee o1 = new Employee();
        Employee o2 = new Employee();
        Employee o3 = new Employee();

        Console.WriteLine(o1.EmpNo); 
        Console.WriteLine(o2.EmpNo); 
        Console.WriteLine(o3.EmpNo); 

        Console.WriteLine(o3.EmpNo); 
        Console.WriteLine(o2.EmpNo); 
        Console.WriteLine(o1.EmpNo); 
    }
}