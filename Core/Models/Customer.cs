using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if(value >= 0 && value <= 110)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                }
            }
        }
        public string PostCode { get; set; }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = Math.Round(value, 2);
            }
        }
        private double _height;
        private int _age;
        public Customer( string name, int age, string postCode, double height)
        {
            ID = Guid.NewGuid();
            Name = name;
            Age = age;
            PostCode = postCode;
            Height = height;
        }
    }
}
