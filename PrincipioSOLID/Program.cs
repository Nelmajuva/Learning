namespace Learning;

class PrincipioSOLID
{
    public void Main(string[] args)
    {
        //Single Child Responsability
        //ExportHelper exportHelper = new();
        //StudentRepository studentRepository = new();

        //IEnumerable<Student> listOfStudents = studentRepository.GetAll();
        //exportHelper.ExportStudents(listOfStudents);

        //Console.WriteLine("¡Datos de los estudiantes exportados!");
    }

    private void CalculateSalaryMonthlyEmployees(List<object> listOfEmployees)
    {
        listOfEmployees.ForEach((employee) =>
        {
            decimal salary;
            decimal hourValue;

            if (employee is EmployeeFullTime)
            {
                hourValue = 300000M;
                EmployeeFullTime employeeFullTime = (EmployeeFullTime)employee;
                salary = hourValue * employeeFullTime.HoursWorked;

                Console.WriteLine($"Empleado {employeeFullTime.FullName}, gana en tiempo completo un total de {salary}");

                return;
            }

            hourValue = 20000M;
            EmployeePartialTime employeePartialTime = (EmployeePartialTime)employee;
            salary = hourValue * employeePartialTime.HoursWorked;

            if (employeePartialTime.HoursWorked > 160)
            {
                decimal effortCompensation = 500M;
                int extraDays = employeePartialTime.HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }

            Console.WriteLine($"Empleado {employeePartialTime.FullName}, gana en medio tiempo un total de {salary}");
        });
    }
}