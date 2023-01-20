class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Contract Contract { get; set; }

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Contract = new TraineeContract();
    }

    public void ChangeName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void ChangeContract(Contract contract)
    {
        Contract = contract;
    }

    public double GetSalary()
    {
        return Contract.GetSalary();
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - Salary: {GetSalary()}";
    }
}

abstract class Contract
{
    public abstract double GetSalary();
}

class CustomContract : Contract
{
    public double Salary { get; set; }
    public override double GetSalary()
    {
        return Salary;
    }
}