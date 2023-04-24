# Customer-Editor
 
### Technology Stack

- Visual Studio 2022
- C# WPF .NET CORE (XAML)
Customer Editor Task.

Programming pattern used. Model View ViewModel. Where Customer is a model, containing name, age, postcode, and height fields. Also, properties used to constrain the input values, via setters. Guid used as a primary key.

View is separated two classe MainWindow, and Editor for creating/updating records.
CustomerEditorViewModel is a viewmodel class used to operate with the model and separate this logic from XAML frontend.
DataAccessFactory is a factory method pattern that defines a method, which should be used for creating objects instead of using a direct constructor call. It generates test data for the records, and passes to the ViewModel class.

To notify the data fields, about the changes, for example user input, the BaseNotification class automatically triggers OnPropertyChanged event.
Separated the WPF and the main logic with different solutions. 

### Future Changes:
- Property boolean flag in Customer Class representing the valid input states, if false notify the ViewModel
- Improve the Editor xaml that will change the forms, including not only adding, but editing
- Improve xaml markup for the MainWindow, correct margins and fonts.
