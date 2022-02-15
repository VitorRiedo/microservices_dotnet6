using Calculadora.Model;

namespace Calculadora.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            //Deletar
        }

        public List<Person> FindAll()
        {
            List<Person> listPerson = new List<Person>();

            listPerson.Add(new Person { Id = 1, Age = 25, Address = "São Paulo", FirstName = "Vitor", LastName = "Riedo" });
            listPerson.Add(new Person { Id = 2, Age = 35, Address = "Rio de Janeiro", FirstName = "Teste", LastName = "Santos" });
            listPerson.Add(new Person { Id = 3, Age = 65, Address = "Mina Gerais", FirstName = "Bilu", LastName = "Souza" });
            listPerson.Add(new Person { Id = 4, Age = 15, Address = "Santa Catarina", FirstName = "Roberta", LastName = "Oliveira" });
            listPerson.Add(new Person { Id = 5, Age = 38, Address = "Amazônia", FirstName = "Luiz", LastName = "Ferreira" });

            return listPerson;
        }

        public Person FindById(long id)
        {
            return new Person { Id = 1, Age = 25, Address = "São Paulo", FirstName = "Vitor", LastName = "Riedo"};
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
