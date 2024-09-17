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

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSemester([FromRoute] int id){

        if(!ModelState.IsValid) return BadRequest(ModelState);

         var semester =  await _semesterRepo.GetSemester(id);

         if(semester ==null){
            return NotFound();
         }

         return Ok(SemesterMappers.ToSemesterDto(semester));
        }
        [HttpGet()]
        public async Task<IActionResult> GetSemesters(){

        if(!ModelState.IsValid) return BadRequest(ModelState);

         var semester =  await _semesterRepo.GetSemesters();

         if(semester ==null){
            return NotFound();
         }

         return Ok(semester.Select(s =>SemesterMappers.ToSemesterDto(s)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateSemeter([FromBody] SemesterDto semesterDto){

            if(!ModelState.IsValid) return BadRequest(ModelState);

            if(semesterDto==null){
                return BadRequest(new {message = "Request body cannot be null"});
            }
            var semester = await _semesterRepo.CreateSemester(semesterDto);

            return CreatedAtAction(nameof(GetSemester),new {id =semester.id},semester);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateSemester([FromRoute] int id , [FromBody] SemesterDto semesterDto){

            if(!ModelState.IsValid) return BadRequest(ModelState);

            var semester = await _semesterRepo.UpdateSemester(id ,semesterDto);

            if(semester ==null ){
                return NotFound();
            }

            return Ok(semester);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteSemester([FromRoute] int id){

            if(!ModelState.IsValid) return BadRequest(ModelState);
            
            var semster = await _semesterRepo.DeleteSemester(id);

            return NoContent();
        }
    }
} 