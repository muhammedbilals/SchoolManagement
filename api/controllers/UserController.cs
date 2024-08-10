using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{

    [Route("api/stock")]
    [ApiController]



    public class UserController: ControllerBase
    {
    private readonly ApplicationDbContext _context;

       public UserController(ApplicationDbContext context)
       {
        _context =context;
       }
       [HttpGet]
        public IActionResult Login(){
            var User = _context.Users.ToList();

            return Ok(User) ;
        }
    }
}