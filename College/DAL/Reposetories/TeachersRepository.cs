using College.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    internal class TeachersRepository<TeacherModel> : ABSRepositoryModel<TeacherModel>
    {
        const string TableName = "Teacher";
        public TeachersRepository() : base(TableName)
        {
        }
    }
}
