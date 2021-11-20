using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsItWorker { get; set; }
        public string Company { get; set; }
        public List<Product> Products { get; set; }

        //internal void Add(string name, Person person)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
