using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invox.Models
{
    public class DbConfig
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string GetConnectionString()
        {
            return $"server={Server};port={Port};database={Database};user={Username};password={Password};";
        }
    }
}
