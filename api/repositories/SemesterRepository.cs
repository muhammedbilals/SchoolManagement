using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.dtos.semester;
using api.interfaces;
using api.mappers;
using api.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace api.repositories
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly ApplicationDbContext _context;
        public SemesterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Semester> CreateSemester(SemesterDto semesterDto)
        {
            var semester = SemesterMappers.ToSemester(semesterDto);
           await _context.semester.AddAsync(semester);
           await _context.SaveChangesAsync();

           return semester;
        }

        public async Task<Semester?> DeleteSemester(int id)
        {
           var sem =await _context.semester.FirstOrDefaultAsync(x => x.id == id);

           if(sem == null){
            return null;
           }
            _context.semester.Remove(sem);
            await _context.SaveChangesAsync();

            return sem;
        }

        public async Task<Semester?> GetSemester(int id)
        {
            return await _context.semester.FirstOrDefaultAsync(s => s.id== id);
        }

        public Task<Semester?> GetSemesters()
        {
            throw new NotImplementedException();
        }

        public async Task<Semester?> UpdateSemester(int id, SemesterDto semesterDto)
        {
            var semester = await _context.semester.FirstOrDefaultAsync(s => s.id== id);

            if(semester == null){
                return null;
            }
            semester.code = semesterDto.code;
            semester.description =semesterDto.description;

            await _context.SaveChangesAsync();

            return semester;
        }
    }
}