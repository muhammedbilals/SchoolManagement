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

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCollege([FromRoute] int id){

            if(!ModelState.IsValid) return BadRequest(ModelState);
            
            var collage = await _collageRepo.GetCollege(id);

            if(collage ==null ){
                return NotFound();
            }

            return Ok(collage);
        }
        [HttpGet]
        public async Task<IActionResult> GetColleges(){

            if(!ModelState.IsValid) return BadRequest(ModelState);
            
            var collage = await _collageRepo.GetColleges();

            if(collage ==null ){
                return NotFound();
            }

            return Ok(collage);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollege([FromBody] CreateCollageDto collageDto){

            if(!ModelState.IsValid) return BadRequest(ModelState);

            var college =collageDto.CreateCollageDto();

            await _collageRepo.CreateCollege(college);

            return CreatedAtAction(nameof(GetCollege) , new {id =college.Id }, college);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCollage([FromRoute] int id){

            if(!ModelState.IsValid) return BadRequest(ModelState);

            var collage = await  _collageRepo.DeleteCollege(id);

            if(collage==null){
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCollage ([FromRoute] int id , [FromBody] CollegeDto collegeDto){

            var college =  await  _collageRepo.UpdateCollege(id ,collegeDto);

            return Ok(college);
        }

        [HttpPost("{collageId}/users/{userId}")]
        public async Task<IActionResult> AddUserToCollage ([FromRoute]int collageId,string userId){

            var result =await _collageRepo.AddUserToCollege(collageId,userId);
            
            if(!result.Success) return BadRequest(result.Message);

            return Ok(result);
        }

        [HttpDelete("{collageId}/users/{userId}")]
        public async Task<IActionResult> RemoveUserFromCollege ([FromRoute]int collageId,string userId){

            var result =await _collageRepo.RemoveUserFromCollege(collageId,userId);
            
            if(!result.Success) return BadRequest(result.Message);

            return NoContent();
        }
    }
}