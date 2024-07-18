using College.Model;
using College.Reposetory;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    public abstract class ABSRepositoryModel<T> : IRepository<T>
    {
        readonly string TableName ;

        protected ABSRepositoryModel(string tableName)
        {
            TableName = tableName;
        }

        public bool Delete(int id)
        {
            string quary = $@"delete from {TableName} where ID = @id";
            var p = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            return DBContext.ExecuteNonQuery(quary, p) > 0;
        }

        public T? FindById(int id)
        {
            string quary = $@"select * from  '{TableName}'  where ID = @id";
            var p = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            var dt = DBContext.ExecuteQuery(quary, p);

            return  (T)Convert.ChangeType(dt.Rows[0], typeof(T));
        }

        public DataTable GetAll()
        {
            string quary = $@"select * from {TableName}";
            var dt = DBContext.ExecuteQuery(quary);
            return dt;
        }

        public bool Insert(T entity )
        {
            SqlParameter[] parameters = (SqlParameter[])
                entity.GetType().GetMethod("GetSqlParameters")!.Invoke(entity, null)!;

            string columnNames = (string)entity.GetType().GetMethod("GetColumnNames")!.Invoke(entity, null)!;

            string columnValues = "";
            foreach (SqlParameter parameter in parameters)
                columnValues += parameter.ParameterName + ",";
            
            

            string quary = $@"insert into {TableName}({columnNames})values({columnValues})";


            return DBContext.ExecuteNonQuery(quary,parameters) > 0;
        }

       

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
