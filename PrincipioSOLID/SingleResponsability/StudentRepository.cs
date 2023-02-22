using System.Text;

public class StudentRepository
{
    private FakeStorage<Student> storage;

    public StudentRepository()
    {
        this.storage = new();
        InitData();
    }

    private void InitData()
    {
        this.storage.Add(new Student(1, "Juan Camilo López Morales", new List<double>() { 5.0, 4.8, 4.7 }));
        this.storage.Add(new Student(2, "Mariana Valencia", new List<double>() { 4.0, 4.8, 5.0 }));
        this.storage.Add(new Student(2, "Lesly Morales", new List<double>() { 4.8, 4.2, 4.0 }));
    }

    public IEnumerable<Student> GetAll()
    {
        return this.storage.GetAll();
    }
}