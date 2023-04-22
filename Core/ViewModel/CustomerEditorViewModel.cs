using Core.Tools;
using Core.Models;
using Core.Factories;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace Core.ViewModel
{
    public class CustomerEditorViewModel : BaseNotificationClass
    {
        private Customer? _currentCustomer;
        public Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set 
            { 
                _currentCustomer = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Customer> Customers { get; set; }

        public CustomerEditorViewModel()
        {
            CurrentCustomer = new Customer("Jane Hawking", 28, "PL2 2VV", 1.71);
            Customers = DataAccessFactory.Customers;
        }

        public void SetCustomerByID(Guid id)
        {
            if(DataAccessFactory.CustomerByID(id) != null)
            {
                CurrentCustomer = DataAccessFactory.CustomerByID(id);
            }
        }

        public void AddCustomer(string name, string age, string postcode, string height)
        {
            DataAccessFactory.AddCustomer(name, age, postcode, height);
        }

        public void UpdateCustomer(Guid id, string name, string age, string postcode,string height)
        {
            DataAccessFactory.UpdateUser(id, name, age, postcode, height);
        }
    }
}
