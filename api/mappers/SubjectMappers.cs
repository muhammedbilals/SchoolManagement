using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.subject;
using api.models;

namespace api.mappers
{
    public static class SubjectMappers
    {
        public static SubjectDto ToSubjectDto(this Subject subject){
            return new SubjectDto{
                CourseId =subject.CourseId,
                SubjectCode = subject.SubjectCode,
                Title = subject.Title
            };
        }

          public static Subject ToSubject(this SubjectDto subjectDto){
            return new Subject{
                CourseId =subjectDto.CourseId,
                SubjectCode = subjectDto.SubjectCode,
                Title = subjectDto.Title
            };
        }
    }
}