class EmployeePartialTime
{
    public string FullName { get; set; }
    public int HoursWorked { get; set; }

    public EmployeePartialTime(string fullName, int hoursWorked)
    {
        this.FullName = fullName;
        this.HoursWorked = hoursWorked;
    }
}