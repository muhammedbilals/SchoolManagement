using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class CollageSubjects
    {
        public int Id { get; set;}
        public int CollageId { get; set; }
        public int SubjectId { get; set; }
        public int SemesterId { get; set; }
        public College Collage { get; set; }
        public Subject Subject {get; set;}
        public Semester Semester { get; set; }
    }
}