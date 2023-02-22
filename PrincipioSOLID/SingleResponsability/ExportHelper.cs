using System.Text;

public class ExportHelper
{
    public void ExportStudents(IEnumerable<Student> listOfStudents)
    {
        string fileCsv = String.Join(",", listOfStudents.Select((student) => student.ToString()).ToArray());

        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("Id;FullName;Grades");

        foreach (Student student in listOfStudents)
        {
            stringBuilder.AppendLine($"{student.Id};{student.FullName};{String.Join("|", student.Grades)}");
        }

        File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), stringBuilder.ToString(), Encoding.Unicode);
    }
}