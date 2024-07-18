using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    internal class CourseCycleModel
    {
        public CourseCycleModel(int id, int course_ID, DateTime startDate, int price, int daysInWeek_ID, int hours_ID)
        {
            Id = id;
            Course_ID = course_ID;
            StartDate = startDate;
            Price = price;
            DaysInWeek_ID = daysInWeek_ID;
            Hours_ID = hours_ID;
        }

        public int? Id { get; set; }
        public int Course_ID { get; set; }
        DateTime StartDate { get; set; }
        public int Price { get; set; }
        public int DaysInWeek_ID { get; set; }
        public int Hours_ID { get; set; }


    }
}
