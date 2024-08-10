using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.interfaces;
using api.repositories;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{
    [Route("api/college")]
    [ApiController]
    public class CollegeController : ControllerBase
    {

        private readonly CollegeRepository _collageRepo;
        public CollegeController(CollegeRepository collegeRepo)
        {
            _collageRepo = collegeRepo;
        }

        [HttpGet]
        public async Task<IActionResult> getCollege(){
            var collage = _collageRepo.GetCollege();

            return Ok(collage);
        }
    }
}