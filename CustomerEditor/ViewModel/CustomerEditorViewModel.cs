using CustomerEditor.Tools;
using CustomerEditor.Models;
using CustomerEditor.Factories;
using System.Collections.ObjectModel;

namespace CustomerEditor.ViewModel
{
    public class CustomerEditorViewModel : BaseNotificationClass
    {
        private Customer _currentCustomer;
        public Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set 
            { 
                _currentCustomer = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Customer> Customers;

        public CustomerEditorViewModel()
        {
            CurrentCustomer = new Customer(1003, "Jane Hawking", 28, "PL2 2VV", 1.71);
            Customers = DataAccessFactory.Customers;
        }

        public void SetCustomerByID(string id)
        {
            if(DataAccessFactory.CustomerByID(id) != null)
            {
                CurrentCustomer = DataAccessFactory.CustomerByID(id);
            }
        }

        public void AddCustomer(string name)
        {
            //DataAccessFactory.AddCustomer()
        }

        public void UpdateCustomer(string id, string name, string age, string postcode,string height)
        {
            DataAccessFactory.UpdateUser(id, name, age, postcode, height);
        }
    }
}
