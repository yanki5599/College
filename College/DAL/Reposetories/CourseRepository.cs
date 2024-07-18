using College.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.DAL.Reposetories
{
    public class CourseRepository : ABSRepositoryModel<CourseModel>
    {
        const string TableName = "Course";

        public CourseRepository() : base(TableName)
        {
        }
    }
}
