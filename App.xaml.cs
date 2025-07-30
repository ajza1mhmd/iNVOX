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

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string configPath = Path.Combine(localAppData, "InvoxApp", "dbconfig.json");

            if (!File.Exists(configPath))
            {
                new DBConfigWindow { DataContext = new DbConfigViewModel() }.Show();
            }
            else
            {
                new Login_page().Show();
            }

        }

    }
}