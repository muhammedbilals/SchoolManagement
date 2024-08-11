using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.semester;
using api.models;

namespace api.interfaces
{
    public interface ISemesterRepository
    {
        public  Task<Semester?> GetSemester(int id);
        public  Task<Semester> CreateSemester(SemesterDto semesterDto);
        public  Task<Semester?> UpdateSemester(int id ,SemesterDto semesterDto);
        public  Task<Semester?> DeleteSemester(int id);

    }
}