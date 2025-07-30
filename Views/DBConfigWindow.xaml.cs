using Invox.ViewModels;
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

namespace Invox.Views
{
    /// <summary>
    /// Interaction logic for DBConfigWindow.xaml
    /// </summary>
    public partial class DBConfigWindow : Window
    {
        private DbConfigViewModel vm;
        public DBConfigWindow()
        {
            InitializeComponent();
            vm = new DbConfigViewModel();
            DataContext = vm;
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Sync password from PasswordBox to ViewModel
            vm.Password = (sender as PasswordBox).Password;
        }
    }
}
