class EmployeeFullTime
{
    public string FullName { get; set; }
    public int HoursWorked { get; set; }

    public EmployeeFullTime(string fullName, int hoursWorked)
    {
        this.FullName = fullName;
        this.HoursWorked = hoursWorked;
    }
}