using PeopleWebSrv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleWebSrv.Controllers
{
    public class PersonController : ApiController
    {
        internal IPersonRepository _people = new PersonRepository();

        [HttpGet]
        public IEnumerable<Person> GetAllPeople()
        {
            return _people.GetAll();
        }

        [HttpGet]
        public IHttpActionResult GetPerson(int id)
        {
            return Ok(_people.Get(id));
        }

        [HttpPost]
        public Person AddPerson(string firstName, string lastName)
        {
            return _people.Add(new Person {FirstName = firstName, LastName = lastName });
        }

        [HttpDelete]
        [AcceptVerbs("DELETE")]
        public void DeletePerson(int id)
        {
            _people.Remove(id);
        }

        [HttpPut]
        public bool UpdatePerson(Person person)
        {
            _people.Update(person);
            return false;
        }
    }
}
