using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace api.models
{
    public class User : IdentityUser
    {
        public List<CollageAdmins> CollageAdmins {get; set;} = new List<CollageAdmins>();
       
    }
}