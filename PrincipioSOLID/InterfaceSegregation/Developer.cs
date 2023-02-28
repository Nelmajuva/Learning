namespace PrincipioSOLID.InterfaceSegregation
{
    public class Developer : IActivities
    {
        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Design()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
