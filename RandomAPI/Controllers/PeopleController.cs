using RandomAPI.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace RandomAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my peeps/
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", Id = 1 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 2 });
            people.Add(new Person { FirstName = "Frodo", LastName = "Baggins", Id = 3 });
        }
        // GET api/People
        public List<Person> Get()
        {
            return people;
        }

        [Route("api/People/NewNames")]
        [HttpPost]

        public string CreateNewName(string first, string last)
        {
            var sb = new StringBuilder();

            sb.Append(first);
            sb.Append(" ");
            sb.Append(last);

            var name = sb.ToString();

            return name;
        }

        // GET api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Gets a list of the first names of all users
        /// </summary>
        /// <returns>A list of first names</returns>
        [Route("api/People/FirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add(person.FirstName);
            }

            return output;
        }

        // POST api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE api/People/5
        public List<Person> Delete(int id)
        {
            var person = people.Where(x => x.Id == id).FirstOrDefault();
            people.Remove(person);
            return people;
        }
    }
}