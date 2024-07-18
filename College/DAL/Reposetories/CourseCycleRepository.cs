using College.Model;
using College.Reposetory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    internal class CourseCycleRepository : IRepository<CourseCycleModel>
    {
        const string TableName = "Course";

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CourseCycleModel? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            string quary = $@"select c.Name, cc.* from {TableName} c join CourseCycle cc 
                                on c.ID = cc.Course_ID";
            var dt = DBContext.ExecuteQuery(quary);

           
            return dt;
        }

        public bool Insert(CourseCycleModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CourseCycleModel entity, string valuesWithAtSimbol, params SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public bool Update(CourseCycleModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
