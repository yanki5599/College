using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    internal class AdminUser
    {
        private DataRow dataRow;

        public AdminUser(DataRow dataRow)
        {
            ID          = (int)dataRow["ID"];
            Password    = (byte[])dataRow["Password"];
            NatID       = (string)dataRow["NatID"];
            FullName    = (string)dataRow["FullName"];
        }

        public AdminUser(int? iD, byte[]? password,string employeeNat, string fullName)
        {
            ID = iD;
            Password = password;
            NatID = employeeNat;
            FullName = fullName;

        }

        public int? ID { get; set; } // Primary key, identity column
        public byte[]? Password { get; set; }
        public string NatID { get; set; } // TEUDAT ZEHUT, unique
        public string FullName { get; set; }
    }
}
