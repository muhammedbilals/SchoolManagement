using api.dtos.subject;
using api.interfaces;
using api.mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{
    [Route("api/subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository _subjectRepo;
        public SubjectController(ISubjectRepository subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubject([FromRoute] int id){
            var subject = await _subjectRepo.GetSubject(id);

            if(subject == null){
                return NotFound();
            }

            return Ok(subject);
        }

        [HttpGet]
        public async Task<IActionResult> getSubjects (){
            var subjects = await _subjectRepo.GetSubjects();

            return Ok(subjects);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubject([FromBody] SubjectDto subjectDto){
            var subject = await _subjectRepo.CreateSubject(subjectDto.ToSubject());

            return CreatedAtAction(nameof(GetSubject), new {id = subject.Id},subject);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubject([FromRoute]int id ,[FromBody]SubjectDto subjectDto){
            var subject = await _subjectRepo.UpdateSubject(id , subjectDto.ToSubject());

            if(subject == null ){
                return NotFound();
            }

            return Ok(subject);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubject([FromRoute]int id ){
            var subject = await _subjectRepo.DeleteSubject(id);

            if(subject == null){
                return NotFound();
            }

            return NoContent();
        }
    }
}