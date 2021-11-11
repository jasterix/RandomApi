﻿using RandomAPI.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RandomAPI.Controllers
{
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

        // GET api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
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