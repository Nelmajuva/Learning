namespace PrincipioSOLID.LiskovPrinciple
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string fullName, int hoursWorked) {
            this.FullName = fullName;
            this.HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalary();
    }
}
