using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.dtos.subject;
using api.interfaces;
using api.mappers;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext _context;
        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public Task<Subject?> GetSubjectById(int id)
        {
            var subject = GetSubjectById(id);

            return subject;
        }
        public async Task<Subject> CreateSubject(Subject subject)
        {
            await _context.subject.AddAsync(subject);
            await _context.SaveChangesAsync();

            return subject;
        }

        public async Task<Subject?> DeleteSubject(int id)
        {
          var subject = await GetSubjectById(id);

            if(subject ==null){
                return null;
            }
            _context.subject.Remove(subject);
            await  _context.SaveChangesAsync();

            return subject;
        }

        public Task<Subject?> GetSubject(int id)
        {
            var subject = GetSubjectById(id);

            return subject;
        }

     

        public Task<List<Subject>> GetSubjects()
        {
            var subjects = _context.subject.ToListAsync();

            return subjects;
        }

        public async Task<Subject?> UpdateSubject(int id, Subject subject)
        {
               var sub = await GetSubjectById(id);

               if(sub == null){
                return null;
               }

               sub.CourseId = subject.CourseId;
               sub.SubjectCode = subject.SubjectCode;
               sub.Title = subject.Title;
               await _context.SaveChangesAsync();

               return sub;
        }
    }
}