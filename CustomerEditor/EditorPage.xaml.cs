using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Core.ViewModel;

namespace CustomerEditor
{
    /// <summary>
    /// Interaction logic for EditorPage.xaml
    /// </summary>
    public partial class EditorPage : Window
    {
        public CustomerEditorViewModel _context => DataContext as CustomerEditorViewModel;
        public EditorPage()
        {
            InitializeComponent();
            name_txt.Text = _context.CurrentCustomer.Name;
            age_txt.Text = _context.CurrentCustomer.Age.ToString();
            postcode_txt.Text = _context.CurrentCustomer.PostCode;
            height_txt.Text = _context.CurrentCustomer.Height.ToString();
        }

        private void OnClick_CreateCustomer(object sender, RoutedEventArgs e)
        {
            _context.AddCustomer(name_txt.Text, age_txt.Text, postcode_txt.Text, height_txt.Text);
        }

        private void OnClick_EditCustomer(object sender, RoutedEventArgs e)
        {
            _context.UpdateCustomer(_context.CurrentCustomer.ID, name_txt.Text, age_txt.Text, postcode_txt.Text, height_txt.Text);
        }
    }
}
