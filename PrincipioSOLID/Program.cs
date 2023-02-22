namespace Learning;

class PrincipioSOLID
{
    public static void Main(string[] args)
    {
        ExportHelper exportHelper = new();
        StudentRepository studentRepository = new();
        
        IEnumerable<Student> listOfStudents = studentRepository.GetAll();
        exportHelper.ExportStudents(listOfStudents);

        Console.WriteLine("¡Datos de los estudiantes exportados!");
    }
}