using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Extensions
{
    public static class TypeOfEducationExtension
    {
        public static TypeOfEducationDto ToDto(this TypeOfEducation typeOfEducation)
        {
            return new TypeOfEducationDto
            {
                Id = typeOfEducation.Id,
                EducationName = typeOfEducation.EducationName,
                SchoolClasses = typeOfEducation.SchoolClasses,
            };
        }

        public static TypeOfEducation ToModel(this TypeOfEducationDto typeOfEducationDto)
        {
            return new TypeOfEducation
            {
                Id = typeOfEducationDto.Id,
                EducationName = typeOfEducationDto.EducationName,
                SchoolClasses = typeOfEducationDto.SchoolClasses,
            };
        }
    }
}
