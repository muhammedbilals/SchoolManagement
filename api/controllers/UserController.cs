using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.dtos.user;
using api.interfaces;
using api.mappers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.controllers
{
    [Route("api/users")]
    [ApiController]

    public class UserController: ControllerBase {
        
    private readonly IUserRepository _userRepo;

       public UserController(IUserRepository userRepo)
       {
            _userRepo =userRepo;
       }
       [HttpGet("getusers")]
        public async Task<IActionResult> GetUsers(){

            var User = await _userRepo.GetUsers();
            var UserDto = User.Select(s => s.ToUserDto());

            return Ok(UserDto);
        }

        
        // [HttpPost("login")]
        // public async Task<IActionResult> Login([FromBody] LoginUserDto userDto ){

        //     var userModel = userDto.ToLoginDto();
        //     var user =await _userRepo.GetUserByEmail(userModel.Email);

        //     if (user ==null){
        //         return NotFound(new {message = "User not found"});
        //     }

        //     // if (user. != userModel.Password){
        //     //     return Unauthorized(new {message ="Wrong Password"});
        //     // }

        //     return Ok(new {message ="Login Successfull", user = user.ToUserDto()});

        // }   
    }
}
