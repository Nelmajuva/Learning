namespace PrincipioSOLID.LiskovPrinciple
{
    internal class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullName, int hoursWorked, int extraHours) : base(fullName, hoursWorked, extraHours)
        {
        }

        public override decimal CalculateSalary()
        {
            decimal hourValue = 40;
            return hourValue * this.HoursWorked;
        }
    }
}
