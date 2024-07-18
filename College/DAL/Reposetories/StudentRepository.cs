using College.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    public class StudentRepository : ABSRepositoryModel<StudentModel>
    {
        const string TableName = "Student";
        public StudentRepository() : base(TableName)
        {
        }
    }
}
