using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEjemplos.Data
{
    public class LoginStatus
    {
        public LoginStatus() { }

        public LoginStatus(bool status, int userId)
        {
            IsLoggedIn = status;
            UserId = userId;
        }

        public bool IsLoggedIn { get; set; }
        public int UserId { get; set; }
    }
}
