using Invox.Common;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.IO;

namespace Invox.ViewModels
{
    public class DbConfigViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        GlobalValues global = new GlobalValues();
        private string _host;
        private string _port;
        private string _username;
        private string _password;
        private string _database;

        public string Host { get => _host; set { _host = value; OnPropertyChanged(); } }
        public string Port { get => _port; set { _port = value; OnPropertyChanged(); } }
        public string Username { get => _username; set { _username = value; OnPropertyChanged(); } }
        public string Password { get => _password; set { _password = value; OnPropertyChanged(); } }
        public string Database { get => _database; set { _database = value; OnPropertyChanged(); } }

        public ICommand TestDbConfigCmd { get; set; }
        public ICommand SaveDbConfigCmd { get; set; }

        public DbConfigViewModel()
        {
            TestDbConfigCmd = new RelayCommand(TestConnectionWithMessage);
            SaveDbConfigCmd = new RelayCommand(SaveToConfig);
        }
        public void TestConnectionWithMessage()
        {
            if (TestConnection())
            {
                MessageBox.Show("Connection successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Connection failed. Please check the database settings.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public bool TestConnection()
        {
            string connStr = $"server={Host};port={Port};database={Database};user={Username};password={Password}";
            using var conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SaveToConfig()
        {
            try
            {
                var config = new { Host, Port, Username, Password, Database };

                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string configDir = Path.Combine(localAppData, "InvoxApp");
                Directory.CreateDirectory(configDir);

                string configPath = Path.Combine(configDir, "dbconfig.json");
                File.WriteAllText(configPath, System.Text.Json.JsonSerializer.Serialize(config));

                MessageBox.Show("Configuration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed. Please check the database settings.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
