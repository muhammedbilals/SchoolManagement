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

        private readonly ICollegeRepository _collageRepo;
        public CollegeController(ICollegeRepository collegeRepo)
        {
            _collageRepo = collegeRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getCollege([FromRoute] int id){
            var collage = await _collageRepo.GetCollege(id);

            if(collage ==null ){
                return NotFound();
            }

            return Ok(collage);
        }
    }
}