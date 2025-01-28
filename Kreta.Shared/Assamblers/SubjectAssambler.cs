using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;

namespace Kreta.Shared.Assamblers
{
    public class SubjectAssambler : Assambler<Subject, SubjectDto>
    {
        public override SubjectDto ToDto(Subject model)
        {
            return model.ToDto();
        }

        public override Subject ToModel(SubjectDto dto)
        {
            return dto.ToModel();
        }
    }
}
