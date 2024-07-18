using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    internal class TopicModel
    {
        public TopicModel(int id, string name, int hoursTotal)
        {
            Id = id;
            Name = name;
            HoursTotal = hoursTotal;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HoursTotal { get; set; }


    }
}
