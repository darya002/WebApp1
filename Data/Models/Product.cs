using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string TextType { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public int TimeForTask { get; set; }
        public int Price { get; set; }
        public int PersonId { get; set; }      // внешний ключ
        public Person Person { get; set; } 
       
    }
}
