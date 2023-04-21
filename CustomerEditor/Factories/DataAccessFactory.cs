using System;
using System.Collections.ObjectModel;
using CustomerEditor.Models;

namespace CustomerEditor.Factories
{
    public static class DataAccessFactory
    {
        private static ObservableCollection<Customer> _customers = new ObservableCollection<Customer>();
        private static int _currentCustomerID = 0;
        public static ObservableCollection<Customer> Customers => _customers;


        static DataAccessFactory()
        {
            _customers.Add(new Customer(1001, "Jane Doe", 27, "PL1 1GF", 1.66));
            _customers.Add(new Customer(1002, "Frank Lampard", 33, "PL3 8GH", 1.84));
            _customers.Add(new Customer(1003, "Ariana Grande", 23, "PL5 6FD", 1.63));
        }

        public static void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public static Customer CustomerByID(string id)
        {
            _currentCustomerID = InputToInt(id);

            foreach(Customer customer in _customers)
            {
                if(customer.ID == InputToInt(id))
                {
                    return customer;
                }
            }

            return null;
        }

        public static void UpdateUser(string id, string name, string age, string postcode, string height)
        {
            foreach(Customer customer in _customers)
            {
                if(customer.ID == InputToInt(id))
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
            catch(FormatException e)
            {
                return 0;
            }

            return 0;
        }

        private static double InputToDouble(string value)
        {
            try
            {
                double result = double.Parse(value);
                return result;
            }
            catch(FormatException e)
            {
                return 0;
            }

            return 0;
        }
    }
}
