using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Attendance
{
    internal class UserSession
    {
        public static string LoggedInUserEmail { get; private set; }

        public static void SetLoggedInUserEmail(string email)
        {
            LoggedInUserEmail = email;
        }
    }
}
