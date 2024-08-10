using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.dtos.user;
using api.mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.controllers
{
    [Route("api/users")]
    [ApiController]

    public class UserController: ControllerBase
    {
    private readonly ApplicationDbContext _context;

       public UserController(ApplicationDbContext context)
       {
        _context =context;
       }
       [HttpGet("getusers")]
        public async Task<IActionResult> GetUsers(){
            var User = await _context.Users.ToListAsync();
            var UserDto = User.Select(s => s.ToUserDto());

            return Ok(UserDto);
        }

        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto userDto ){
            var userModel = userDto.ToLoginDto();
            var user =await _context.Users.FirstOrDefaultAsync(u => u.Email == userModel.Email);
        if (user ==null){
            return NotFound(new {message = "User not found"});
        }

        if (user.Password != userModel.Password){
            return Unauthorized(new {message ="Wrong Password"});
        }

        return Ok(new {message ="Login Successfull", user = user.ToUserDto()});
        }   
    }
}
