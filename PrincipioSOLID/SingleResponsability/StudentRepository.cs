namespace PrincipioSOLID.SingleResponsability
{
    public class StudentRepository
    {
        private FakeStorage<Student> storage;

        public StudentRepository()
        {
            storage = new();
            InitData();
        }

        private void InitData()
        {
            storage.Add(new Student(1, "Juan Camilo López Morales", new List<double>() { 5.0, 4.8, 4.7 }));
            storage.Add(new Student(2, "Mariana Valencia", new List<double>() { 4.0, 4.8, 5.0 }));
            storage.Add(new Student(2, "Lesly Morales", new List<double>() { 4.8, 4.2, 4.0 }));
        }

        public IEnumerable<Student> GetAll()
        {
            return storage.GetAll();
        }
    }
}