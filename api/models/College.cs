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
        public List<CollageSubjects> collageSubjects {get; set;} = new List<CollageSubjects>();
    }
}