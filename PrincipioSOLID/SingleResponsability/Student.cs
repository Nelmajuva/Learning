namespace PrincipioSOLID.SingleResponsability
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<double> Grades { get; set; }

        public Student()
        {
            FullName = string.Empty;
            Grades = new List<double>();
        }

        public Student(int Id, string FullName, List<double> Grades)
        {
            this.Id = Id;
            this.Grades = Grades;
            this.FullName = FullName;
        }
    }
}