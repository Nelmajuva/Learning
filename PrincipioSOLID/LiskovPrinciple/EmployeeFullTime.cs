namespace PrincipioSOLID.LiskovPrinciple
{
    internal class EmployeeFullTime : Employee
    {
        public int ExtraHours { get; set; }

        public EmployeeFullTime(string fullName, int hoursWorked, int extraHours) : base(fullName, hoursWorked)
        {
            this.ExtraHours = extraHours;
        }

        public override decimal CalculateSalary()
        {
            decimal hourValue = 50;
            return hourValue * (this.HoursWorked + this.ExtraHours);
        }
    }
}
