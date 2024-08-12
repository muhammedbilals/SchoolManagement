using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.semester;
using api.interfaces;
using api.mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace api.controllers
{
    [Route("api/semester")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterRepository _semesterRepo;
        public SemesterController(ISemesterRepository semesterRepo)
        {
            _semesterRepo = semesterRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSemester([FromRoute] int id){
         var semester =  await _semesterRepo.GetSemester(id);

         if(semester ==null){
            return NotFound();
         }

         return Ok(SemesterMappers.ToSemesterDto(semester));
        }

        [HttpPost]
        public async Task<IActionResult> CreateSemeter([FromBody] SemesterDto semesterDto){
            if(semesterDto==null){
                return BadRequest(new {message = "Request body cannot be null"});
            }
            var semester = await _semesterRepo.CreateSemester(semesterDto);

            return CreatedAtAction(nameof(GetSemester),new {id =semester.id},semester);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSemester([FromRoute] int id , [FromBody] SemesterDto semesterDto){
            var semester = await _semesterRepo.UpdateSemester(id ,semesterDto);

            if(semester ==null ){
                return NotFound();
            }

            return Ok(semester);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSemester([FromRoute] int id){
            var semster = await _semesterRepo.DeleteSemester(id);

            return NoContent();
        }
    }
}