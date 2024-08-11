using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.semester;
using api.models;

namespace api.mappers
{
    public static class SemesterMappers
    {
        public static Semester ToSemester(SemesterDto semesterDto){

            return new Semester {
                code = semesterDto.code,
                description =semesterDto.description,
            };
        }
    }
}