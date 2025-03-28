using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlazorTutorial.Services
{
    public interface IPersonService
    {
        Person GetPerson(int personId);
        IReadOnlyCollection<Person> GetPeople();
    }
}

public record Person(
    int PersonId,
    string FirstName,
    string LastName,
    DateOnly BirthDate
);