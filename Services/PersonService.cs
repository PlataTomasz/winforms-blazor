using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlazorTutorial.Services
{
    public class PersonService : IPersonService
    {
        private readonly IList<Person> people = new List<Person>
        {
            new Person(1, "John", "Doe", new DateOnly(2000, 12, 22)),
            new Person(3, "Sabrina", "Miller", new DateOnly(1997, 2, 7)),
            new Person(16, "Claudio", "Bernasconi", new DateOnly(2003, 5, 6))
        };

        public IReadOnlyCollection<Person> GetPeople()
        {
            return people.AsReadOnly();
        }

        Person IPersonService.GetPerson(int personId)
        {
            return people.Single(person => person.PersonId == personId);
        }
    }
}
