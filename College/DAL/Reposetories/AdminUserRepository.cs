using College.Model;
using College.Reposetory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    internal class AdminUserRepository : IRepository<AdminUser>
    {

        const string TableName = "AdminUser";
        public bool Delete(int id)
        {
            string quary = $@"delete from '{TableName}' where ID = @id";
            var p = new SqlParameter("@id", SqlDbType.Int) { Value = id};
            return DBContext.ExecuteNonQuery(quary, p) > 0;
        }

        public AdminUser? FindById(int id)
        {
            string quary = $@"select * from  '{TableName}'  where ID = @id";
            var p = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            var dt =  DBContext.ExecuteQuery(quary, p);
            if (dt == null )
                return null;
            return new AdminUser(dt.Rows[0]);
        }

        public List<AdminUser> GetAll()
        {
            string quary = $@"select * from '{TableName}'";
            DataTable dt =  DBContext.ExecuteQuery(quary);
            var list = new List<AdminUser>();
            foreach(DataRow dr in dt.Rows)
                list.Add(new AdminUser(dr));
            return list;
        }

        public bool Insert(AdminUser entity)
        {
            string quary = $@"insert into '{TableName}' values(@nat , @fullname ,@pass);";
            var parameters = new List<SqlParameter>()
            {
                new SqlParameter("@nat",SqlDbType.VarChar){Value = entity.ID },
                new SqlParameter("@fullname",SqlDbType.NVarChar){Value = entity.FullName},
                new SqlParameter("@pass",SqlDbType.VarBinary){Value = entity.Password},
            };
            return DBContext.ExecuteNonQuery(quary,parameters.ToArray()) > 0;   
        }

        public bool Update(AdminUser entity)
        {
            throw new NotImplementedException();
        }

        internal bool IsUserExist(string natId, out AdminUser? adminUser)
        {
            string quary = $@"select * from {TableName} where NatID = @nat";
            var p = new SqlParameter("@nat", SqlDbType.VarChar) { Value = natId };
            var dt = DBContext.ExecuteQuery(quary, p);

            adminUser = dt.Columns.Contains("ID")? new AdminUser(dt.Rows[0]) : null;

            return adminUser != null;
        }

        internal bool ValidateUserPass(AdminUser? adminUser, string password)
        {
            return Utils.CompareHash(adminUser.Password, password);
        }

        DataTable IRepository<AdminUser>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
