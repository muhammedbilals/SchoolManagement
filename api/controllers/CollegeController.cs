using api.dtos.college;
using api.interfaces;
using api.mappers;
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

        [HttpPost]
        public async Task<IActionResult> createCollege([FromBody] CreateCollageDto collageDto){

            var college =collageDto.CreateCollageDto();

            await _collageRepo.CreateCollege(college);

            return CreatedAtAction(nameof(getCollege) , new {id =college.Id }, college);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteCollage([FromRoute] int id){

            var collage = await  _collageRepo.DeleteCollege(id);

            if(collage==null){
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateCollage ([FromRoute] int id , [FromBody] CollegeDto collegeDto){

            var college =  await  _collageRepo.UpdateCollege(id ,collegeDto);

            return Ok(college);
        }
    }
}