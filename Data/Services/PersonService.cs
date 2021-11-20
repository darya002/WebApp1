using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Repository
{
    public class PersonService : IPersonService
    {
        private readonly AppDBContent appDBContent;

        public PersonService(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Person> AllPeople => appDBContent.Person;
    }
}
