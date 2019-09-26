using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleWebSrv.Models
{
    public class PersonRepository : IPersonRepository
    {
        List<Person> _people = new List<Person>();
        int _fakeDatabaseID = 1;

        public PersonRepository()
        {
            this.Add(new Person { FirstName = "Debashish", LastName = "Sahu" });
            this.Add(new Person { FirstName = "Sanath", LastName = "Shetty" });
            this.Add(new Person { FirstName = "Noora", LastName = "Akhtar" });
            this.Add(new Person { FirstName = "Shashwat", LastName = "Bajpai" });
            this.Add(new Person { FirstName = "Sajid", LastName = "Ahmed" });
        }

        public Person Add(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("person");
            }

            person.Id = _fakeDatabaseID++;
            _people.Add(person);

            return person;
        }

        public Person Get(int id)
        {
            return _people.Find(p => p.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _people;
        }

        public void Remove(int id)
        {
            _people.RemoveAll(p => p.Id == id);
        }

        public bool Update(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("person");
            }

            int index = _people.FindIndex(p => p.Id == person.Id);
            if (index == -1)
            {
                return false;
            }

            _people.RemoveAt(index);
            _people.Add(person);
            return true;
        }
    }
}