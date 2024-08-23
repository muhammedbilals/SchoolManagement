using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class Semester
    {
        public int id {get; set;} 
        public string code {get; set;} = string.Empty;
        public string description {get; set;}  = string.Empty;
        public List<CollageSubjects> CollageSubjects {get; set;} = new List<CollageSubjects>();


    }
}