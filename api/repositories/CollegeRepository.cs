using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.dtos.college;
using api.interfaces;
using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.repositories
{
    public class CollegeRepository : ICollegeRepository
    {
        private readonly ApplicationDbContext _context;

        public CollegeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<College> CreateCollege(College collage)
        {
             await _context.College.AddAsync(collage);
             await _context.SaveChangesAsync();
             return collage;
        }

        public async Task<College?> DeleteCollege(int id)
        {
          var college =await _context.College.FirstOrDefaultAsync(a => a.Id ==id);

          if(college==null){
            return null;
          }
          _context.Remove(college);
          await _context.SaveChangesAsync();

          return college;
        }

        public async Task<College?> GetCollege(int id)
        {
            return await _context.College.FirstOrDefaultAsync(s => s.Id == id);
        }

        public Task<College> UpdateCollege()
        {
            throw new NotImplementedException();
        }
    }
}