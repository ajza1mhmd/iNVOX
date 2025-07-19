using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invox.Models
{
    public class Users
    {
        public int Pu_Id { get; set; }
        public string Pu_User_Id { get; set; }
        public string Pu_Name { get; set; }
        public string? Pu_Email { get; set; }
        public string? Pu_Mobile { get; set; }
        public string Pu_Password { get; set; }
        public string Pu_Level { get; set; }
        public DateTime? Pu_Last_Login { get; set; }
        public string? Pu_Trans_Yn { get; set; }
        public DateTime? Pu_Created_On { get; set; }
        public string? Pu_Created_By { get; set; }
        public DateTime? Pu_Updated_On { get; set; }
        public string? Pu_Updated_By { get; set; }
    }
}
