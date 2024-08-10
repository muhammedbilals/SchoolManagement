using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.models;

namespace api.interfaces
{
    public interface ICollegeRepository
    {
        public Task<College> CreateCollege();
        public Task<College?> GetCollege(int id);
        public Task<College> UpdateCollege();
        public Task<College> DeleteCollege();


    }
}