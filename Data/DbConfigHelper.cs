using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Invox.Data
{
    public class DbConfig
    {
        public string host { get; set; }
        public string port { get; set; }
        public string database { get; set; }
        public string user { get; set; }
        public string password { get; set; }
    }

    public static class DbConfigHelper
    {
        public static string GetConnectionString()
        {
            var json = File.ReadAllText("Data/dbconfig.json");
            var config = JsonSerializer.Deserialize<DbConfig>(json);
            return $"server={config.host};port={config.port};database={config.database};user={config.user};password={config.password}";
        }
    }
}
