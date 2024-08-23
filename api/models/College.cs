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
        public List<CollageSubjects> CollageSubjects {get; set;} = new List<CollageSubjects>();
        public List<CollageAdmins> CollageAdmins {get; set;} = new List<CollageAdmins>();
    }
}