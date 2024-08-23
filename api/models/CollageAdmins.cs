using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.models
{
    public class CollageAdmins
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CollageId { get; set; }
        public User User{get; set;}
        public College College { get; set; }
    }
}