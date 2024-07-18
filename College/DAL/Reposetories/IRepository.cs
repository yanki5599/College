using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Reposetory
{
    internal interface IRepository<T>
    {
        DataTable GetAll();
        T? FindById(int id);
        bool Insert(T entity);

        bool Update(T entity);
        bool Delete(int id);
    }
}
