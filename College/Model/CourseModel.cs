using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    public class CourseModel : IModel
    {
        public CourseModel(int? iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public int? ID { get; set; }
        public string Name { get; set; }

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

        public SqlParameter[] GetSqlParameters()
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@id",SqlDbType.Int){Value = ID},
                new SqlParameter("@name",SqlDbType.NVarChar){Value = Name},
            }.ToArray();
        }
    }
}
