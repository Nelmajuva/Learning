class EmployeeFullTime : Employee
{
    public EmployeeFullTime(string fullName, int hoursWorked) : base(fullName, hoursWorked)
    {
        this.FullName = fullName;
        this.HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 300000M;
        decimal salary = hourValue * this.HoursWorked;

        return salary;
    }
}