using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.interfaces;
using api.models;

namespace api.repositories
{
    public class CollegeRepository : ICollegeRepository
    {
        private readonly ApplicationDbContext _context;

        public CollegeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<College> CreateCollege()
        {
            throw new NotImplementedException();
        }

        public Task<College> DeleteCollege()
        {
            throw new NotImplementedException();
        }

        public async  Task<College> GetCollege()
        {
            throw new NotImplementedException();
        }

        public Task<College> UpdateCollege()
        {
            throw new NotImplementedException();
        }
    }
}