using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.user;
using api.models;

namespace api.mappers
{
    public static class UserMappers
    {
        public static UserDto ToUserDto (this User user)
        {
            return new UserDto{
                 Email =user.Email,
                 Name =user.Name
            };
        }
    }
}