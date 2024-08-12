using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.subject;
using api.models;

namespace api.interfaces
{
    public interface ISubjectRepository
    {
        public Task<List<Subject>> GetSubjects();
        public Task<Subject?> GetSubject(int id);
        public Task<Subject?> UpdateSubject(int id, Subject subject);
        public Task<Subject> CreateSubject(Subject subject);
        public Task<Subject?> DeleteSubject(int id);
        public Task<Subject?> GetSubjectById(int id);


    }
}