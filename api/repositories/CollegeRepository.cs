
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
        
        public async Task<List<College>> GetColleges()
        {
           return await _context.College.ToListAsync();
        }

        public async Task<List<College>> GetCollegesById(string id)
        {
           return await _context.College.Where(s => s.Users.Any(c => c.Id == id)).ToListAsync();
        }

        public async Task<College?> UpdateCollege(int id ,CollegeDto collegeDto)
        {
           var college = await _context.College.FirstOrDefaultAsync(x => x.Id ==id);

           if(college==null){
            return null;
           }

           college.Name =collegeDto.Name;
           college.CollageCode =collegeDto.CollageCode;

            await _context.SaveChangesAsync();

            return college;
        }
    }
}