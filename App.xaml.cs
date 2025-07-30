using Invox.ViewModels;
using Invox.Views;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace Invox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (!File.Exists("Data/dbconfig.json"))
            {
                new DBConfigWindow { DataContext = new DbConfigViewModel() }.Show();
            }
            else
            {
                new Login_page().Show(); // will do logic in next step
            }

        }

    }
}