using College.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    public class TeacherRepository : ABSRepositoryModel<TeacherModel>
    {
        const string TableName = "Teacher";
        public TeacherRepository() : base(TableName)
        {
        }
    }
}
