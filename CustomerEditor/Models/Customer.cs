using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEditor.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PostCode { get; set; }
        public double Height { get; set; }
        public Customer(int id, string name, int age, string postCode, double height)
        {
            ID = id;
            Name = name;
            Age = age;
            PostCode = postCode;
            Height = height;
        }
    }
}
