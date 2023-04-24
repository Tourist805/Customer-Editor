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
        public CustomerEditorViewModel Context => DataContext as CustomerEditorViewModel;
        public EditorPage()
        {
            InitializeComponent();
            name_txt.Text = Context.CurrentCustomer.Name;
            age_txt.Text = Context.CurrentCustomer.Age.ToString();
            postcode_txt.Text = Context.CurrentCustomer.PostCode;
            height_txt.Text = Context.CurrentCustomer.Height.ToString();
        }

        private void OnClick_CreateCustomer(object sender, RoutedEventArgs e)
        {
            Context.AddCustomer(name_txt.Text, age_txt.Text, postcode_txt.Text, height_txt.Text);
        }

        private void OnClick_EditCustomer(object sender, RoutedEventArgs e)
        {
            Context.UpdateCustomer(Context.CurrentCustomer.ID, name_txt.Text, age_txt.Text, postcode_txt.Text, height_txt.Text);
        }
    }
}
