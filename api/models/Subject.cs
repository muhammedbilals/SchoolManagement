using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; } = string.Empty;
        public string CourseId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public List<CollageSubjects> collageSubjects {get; set;} = new List<CollageSubjects>();

    }
}