using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.dtos.user
{
    public class UserDto
    {
         public int Id { get; set; }
            public string Email { get; set; } =string.Empty;

            public string Name { get; set; } =string.Empty;

            public string Password { get; set; } =string.Empty;

    }
}