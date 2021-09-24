namespace OOP
{
    public interface IRepository
    {
        void Add();
    }

    public class Repository : IRepository
    {
        //public Repository(int a)
        //{

        //}

        public void Add()
        {
            // Add item
        }
    }

    public class RepositoryFake : IRepository
    {
        public void Add()
        {
            // Addd item
        }
    }

    public class ImplementationUse
    {
        public void Process()
        {
            Repository repository = new Repository();
            repository.Add();
        }
    }

    public class AbstractionUse
    {
        private readonly IRepository _repository;

        public AbstractionUse(IRepository repository)
        {
            _repository = repository;
        }

        public void Process()
        {
            _repository.Add();
        }
    }

    public class InterfaceImplementationTest
    {
        public InterfaceImplementationTest()
        {
            ImplementationUse repoImp = new ImplementationUse();
            repoImp.Process();

            AbstractionUse repoAbs = new AbstractionUse(new Repository());
            repoAbs.Process();

            AbstractionUse repoAbsFake = new AbstractionUse(new RepositoryFake());
            repoAbsFake.Process();
        }
    }
}
