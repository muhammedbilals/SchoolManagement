using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class College
    {
        public int Id {set; get;}
        public string CollageCode {set; get;} = string.Empty;
        public string Name { get; set; } =string.Empty;
        public List<Subject> Subjects {get; set;} = new List<Subject>();
        public List<Semester> Semesters {get; set;} = new List<Semester>();

        public ICollection<User> Users { get; set; }
    }
}