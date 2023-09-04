using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_Plus_System
{
    public static class userRole
    {
        public const string AdminRole = "Admin";
        public const string ReceptionistRole = "Receptionist";

        public static bool IsAdmin(string role)
        {
            return string.Equals(role, AdminRole, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsReceptionist(string role)
        {
            return string.Equals(role, ReceptionistRole, StringComparison.OrdinalIgnoreCase);
        }
    }
}
