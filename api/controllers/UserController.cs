using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.dtos.user;
using api.mappers;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetUsers(){
            var User = _context.Users.ToList().Select(s => s.ToUserDto());

            return Ok(User);
        }

        
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUserDto userDto ){
            var userModel = userDto.ToLoginDto();
            var user =_context.Users.FirstOrDefault(u => u.Email == userModel.Email);
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
