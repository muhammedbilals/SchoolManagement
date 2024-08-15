using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.user;
using api.Migrations;
using api.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenServices _tokenService; 
        public AuthController(UserManager<User> userManager,ITokenServices tokenServices)
        {
            _userManager = userManager;
            _tokenService = tokenServices;
        }

        [HttpPost("register")]
        public async Task<IActionResult> register ([FromBody]RegisterDto registerDto ){
            try
            {
                if(!ModelState.IsValid) return BadRequest(ModelState);

                var user = new User{
                    Email = registerDto.Email,
                    UserName = registerDto.Email
                };

                var registerdUser =await _userManager.CreateAsync(user , registerDto.Password);
                if(registerdUser.Succeeded){
                    var roleResult = await _userManager.AddToRoleAsync(user, "CollegeAdmin");
                    if(roleResult.Succeeded){
                        return Ok(new NewUserDto{
                           Tokens =_tokenService.CreateToken(user),
                            Email = registerDto.Email,
                            
                        });
                    }else{
                        return BadRequest(roleResult.Errors);
                    }
                }else {
                    return BadRequest(registerdUser.Errors);
                }
            }
            catch (Exception e)
            {
                
               return StatusCode(500 ,e);
            }
        }
    }
}