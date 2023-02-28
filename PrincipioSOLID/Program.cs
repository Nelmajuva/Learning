namespace Learning;

class PrincipioSOLID
{
    public static void Main(string[] args)
    {
        //Single Child Responsability
        //ExportHelper exportHelper = new();
        //StudentRepository studentRepository = new();

        //IEnumerable<Student> listOfStudents = studentRepository.GetAll();
        //exportHelper.ExportStudents(listOfStudents);

        //Console.WriteLine("¡Datos de los estudiantes exportados!");

        // -------------------------------------------------------------------------

        //Open Closed Principle
        //List<Employee> listOfEmployees = new()
        //{
        //    new EmployeeFullTime("Juan Camilo", 200),
        //    new EmployeePartialTime("Andrea Puerta", 120)
        //};

        //ShowSalaryMonthlyEmployees(listOfEmployees);
    }

    //Open Closed Principle
    //private static void ShowSalaryMonthlyEmployees(List<Employee> listOfEmployees)
    //{
    //    listOfEmployees.ForEach((employee) =>
    //    {
    //        Console.WriteLine($"Empleado {employee.FullName}, gana un total de {employee.CalculateSalaryMonthly()}");
    //    });
    //}

    //Liskov Principle
    //private static void CalculateSalaryMonthly(List<Employee> listOfEmployees)
    //{
    //    foreach (var employee in listOfEmployees)
    //    {
    //        decimal salary = employee.CalculateSalary();
    //        Console.WriteLine($"The {employee.Fullname}'s salary is {salary}");
    //    }
    //}
}