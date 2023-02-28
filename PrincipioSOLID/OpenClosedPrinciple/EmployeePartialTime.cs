public class EmployeePartialTime : Employee
{
    public EmployeePartialTime(string fullName, int hoursWorked) : base(fullName, hoursWorked)
    {
        this.FullName = fullName;
        this.HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 20000M;
        decimal salary = hourValue * this.HoursWorked;

        if (this.HoursWorked > 160)
        {
            decimal effortCompensation = 500M;
            int extraDays = this.HoursWorked - 160;
            salary += effortCompensation * extraDays;
        }

        return salary;
    }
}