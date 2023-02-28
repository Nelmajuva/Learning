namespace PrincipioSOLID.SingleResponsability
{
    public class FakeStorage<T>
    {
        private List<T> listOfElements;

        public FakeStorage()
        {
            this.listOfElements = new ();
        }

        public void Add(T element)
        {
            this.listOfElements.Add(element);
        }

        public List<T> GetAll()
        {
            return this.listOfElements;
        }
    }
}
