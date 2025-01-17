using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.college;
using api.models;
using api.utils;

namespace api.interfaces
{
    public interface ICollegeRepository
    {
        public Task<College> CreateCollege(College collage);
        public Task<College?> GetCollege(int id);
        public Task<List<College>> GetColleges();
        public Task<List<College>> GetCollegesById(string id);
        public Task<College?> UpdateCollege(int id ,CollegeDto collegeDto);
        public Task<College?> DeleteCollege(int id);
        public Task<DbResult<College>> AddUserToCollege(int collegeId, string userId);
        public Task<DbResult<College>> RemoveUserFromCollege(int collegeId, string userId);
        public Task<DbResult<College>> AddSemesterToCollege(int collegeId, string semesterId);
        public Task<DbResult<College>> RemoveSemesterFromCollege(int collegeId, string semesterId);
        public Task<DbResult<List<Semester>>> GetSemestersByCollage(int collegeId);

    }
}