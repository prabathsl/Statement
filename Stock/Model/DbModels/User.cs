using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model.DbModels
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int FailedLogins { get; set; }
        public string LastLoggedIp { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastLoggedDateTime { get; set; }
        public bool IsLocked { get; set; }
    }
}
