using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.dtos.college;
using api.models;

namespace api.mappers
{
    public static class CollegeMappers
    {
        public static College CreateCollageDto (this CreateCollageDto collageDto){
            return new  College{
                CollageCode =collageDto.CollageCode,
                Name =collageDto.Name 
            };
        }
    }
}