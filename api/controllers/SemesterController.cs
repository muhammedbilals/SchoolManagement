using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace api.controllers
{
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterRepository _semesterRepo;
        public SemesterController(ISemesterRepository semesterRepo)
        {
            _semesterRepo = semesterRepo;
        }
        
    }
}