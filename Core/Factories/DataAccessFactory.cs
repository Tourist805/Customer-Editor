using System;
using System.Collections.ObjectModel;
using Core.Models;

namespace Core.Factories
{
    public static class DataAccessFactory
    {
        private static ObservableCollection<Customer> _customers = new ObservableCollection<Customer>();
        private static Guid _currentCustomerID;
        public static ObservableCollection<Customer> Customers => _customers;


        static DataAccessFactory()
        {
            _customers.Add(new Customer("Jane Doe", 27, "PL1 1GF", 1.66));
            _customers.Add(new Customer("Frank Lampard", 33, "PL3 8GH", 1.84));
            _customers.Add(new Customer("Ariana Grande", 23, "PL5 6FD", 1.63));
        }

        public static void AddCustomer(string name, string age, string postcode, string height)
        {
            Customer customer = new Customer(name, InputToInt(age), postcode, InputToInt(height));
            _customers.Add(customer);
        }

        public static Customer? CustomerByID(Guid id)
        {
            _currentCustomerID = id;

            foreach(Customer customer in _customers)
            {
                if(customer.ID == id)
                {
                    return customer;
                }
            }

            return null;
        }

        public static void UpdateUser(Guid id, string name, string age, string postcode, string height)
        {
            foreach(Customer customer in _customers)
            {
                if(customer.ID == id)
                {
                    customer.Name = name;
                    customer.Age = InputToInt(age);
                    customer.PostCode = postcode;
                    customer.Height = InputToDouble(height);
                }
            }
        }

        private static int InputToInt(string value)
        {
            try
            {
                int result = Int32.Parse(value);
                return result;
            }
            catch(FormatException)
            {
                return 0;
            }
        }

        private static double InputToDouble(string value)
        {
            try
            {
                double result = double.Parse(value);
                return result;
            }
            catch(FormatException)
            {
                return 0;
            }
        }
    }
}
