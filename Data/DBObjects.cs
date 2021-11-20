using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Person.Any())
                content.Person.AddRange(People.Select(c => c.Value));

            if (!content.Product.Any())
            {
                content.AddRange(
                     new Product
                     { TextType = "journalistic", Img = "/img/1b767212b90564ce4b52e7b54c0dc81b.jpg", Description = "", Price = 900, TimeForTask = 5, Person = People["Tom"] },
                    new Product
                    { TextType = "journalistic", Img = "/img/1b767212b90564ce4b52e7b54c0dc81b.jpg", Description = "", Price = 50, TimeForTask = 1, Person = People["Max"] },
                    new Product
                    { TextType = "journalistic", Img = "/img/1b767212b90564ce4b52e7b54c0dc81b.jpg", Description = "", Price = 900, TimeForTask = 5, Person = People["Jerry"] },
                    new Product
                    { TextType = "journalistic", Img = "/img/1b767212b90564ce4b52e7b54c0dc81b.jpg", Description = "", Price = 50, TimeForTask = 1, Person = People["Tom"] },
                    new Product
                    { TextType = "journalistic", Img = "/img/1b767212b90564ce4b52e7b54c0dc81b.jpg", Description = "", Price = 900, TimeForTask = 5, Person = People["Jerry"] },
                    new Product
                    { TextType = "journalistic", Img = "/img/1b767212b90564ce4b52e7b54c0dc81b.jpg", Description = "", Price = 50, TimeForTask = 1, Person = People["Max"] }
              );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Person> person;
        public static Dictionary<string, Person> People
        {
            get
            {
                if (person == null)
                {
                    var list = new Person[]
                    {
                        new Person { Name="Tom", Company="Microsoft" },
                        new Person { Name="Jerry", Company="Hp" },
                        new Person { Name="Max", Company="Dell" }
                    };

                    person = new Dictionary<string, Person>();
                    foreach (Person p in list)
                        person.Add(p.Name, p);
                }
                return person;
            }
        }
    }
}
