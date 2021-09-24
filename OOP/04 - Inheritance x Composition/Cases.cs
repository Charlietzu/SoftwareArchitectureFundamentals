using System;

namespace OOP
{
    #region Case 1

    public class FisicalPerson : Person
    {
        public string Cpf { get; set; }
    }

    public class FisicalPerson2
    {
        public Person Person { get; set; }
        public string Cpf { get; set; }
    }

    public class InheritanceCompositionTest
    {
        public InheritanceCompositionTest()
        {
            FisicalPerson inheritancePerson = new FisicalPerson
            {
                Name = "Joao",
                BirthDate = DateTime.Now,
                Cpf = "32165498765"
            };

            FisicalPerson2 compositionPerson = new FisicalPerson2
            {
                Person = new Person
                {
                    Name = "Joao",
                    BirthDate = DateTime.Now,
                },
                Cpf = "32165498765"
            };

            string inheritanceName = inheritancePerson.Name;
            string compositionName = compositionPerson.Person.Name;
        }
    }

    #endregion

    #region Case 2

    public interface IRepository<T>
    {
        void Add(T obj);

        void Delete(T obj);
    }

    public interface IRepositoryPerson
    {
        void Add(Person obj);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Add(T obj)
        {

        }

        public void Delete(T obj)
        {

        }
    }

    public class RepositoryInheritancePerson : Repository<Person>, IRepositoryPerson
    {

    }

    public class RepositoryCompositionPerson : IRepositoryPerson
    {
        private readonly IRepository<Person> _repositoryPerson;

        public RepositoryCompositionPerson(IRepository<Person> repositoryPerson)
        {
            _repositoryPerson = repositoryPerson;
        }

        public void Add(Person obj)
        {
            _repositoryPerson.Add(obj);
        }
    }

    public class InheritanceCompositionTest2
    {
        public InheritanceCompositionTest2()
        {
            RepositoryInheritancePerson repoH = new RepositoryInheritancePerson();
            repoH.Add(new Person());
            repoH.Delete(new Person());

            RepositoryCompositionPerson repoC = new RepositoryCompositionPerson(new Repository<Person>());
            repoC.Add(new Person());
        }
    }

    #endregion
}