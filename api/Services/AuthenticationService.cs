using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;

using api.Models;

namespace api.Services
{
    public class AuthenticationService
    {
        public bool AuthenticateUser(User user)
        {
            if (user.Username == "joh" && user.Password == "test")
                return true;
            else
                return false;
        }
    }
}
