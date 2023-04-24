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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Core.ViewModel;

namespace CustomerEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CustomerEditorViewModel _context = new CustomerEditorViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _context;
        }

        private void Onclick_AddingEditingForm(object sender, RoutedEventArgs e)
        {
            EditorPage editorPage = new EditorPage();
            editorPage.Owner = this;
            editorPage.DataContext = _context;
            editorPage.Show();
        }

       
    }
}
