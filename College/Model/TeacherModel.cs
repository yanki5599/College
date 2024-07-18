using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    public class TeacherModel : IModel
    {
        int? ID { get; set; }
        string NatId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? Phone {  get; set; }
        int HourlyRateNis { get; set; }

        public TeacherModel(int? iD, string natId, string firstName, string lastName, string? phone, int hourlyRateNis)
        {
            ID = iD;
            NatId = natId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            HourlyRateNis = hourlyRateNis;
        }

        public SqlParameter[] GetSqlParameters()
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@id",SqlDbType.Int){Value = ID},
                new SqlParameter("@NatId",SqlDbType.VarChar){Value = NatId},
                new SqlParameter("@fname",SqlDbType.NVarChar){Value = FirstName},
                new SqlParameter("@lname",SqlDbType.NVarChar){Value = LastName},
                new SqlParameter("@Phone",SqlDbType.VarChar){Value = Phone},
                new SqlParameter("@rate",SqlDbType.Int){Value = HourlyRateNis},
            }.ToArray();
        }

        // insure properies names matches sql columns before calling this function
        public string GetColumnNames()
        {
            string columnNames = "";
            var i = this.GetType().GetProperties();

            foreach (var prop in i)
            {
                columnNames += prop.Name + ',';
            }
            return columnNames;
        }
    }
}
