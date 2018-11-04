using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examo.Models.Dto;

namespace Examo.Service
{
    public interface IStudentService
    {
        Guid CreateProfile(CreateStudentProfileDto studentProfile);
        Guid UpdateProfile(UpdateStudentProfileDto studentProfile);
        GetStudentProfileDto GetStudentByGuid(Guid id);
        List<GetStudentProfileDto> GetStudents();
        void DeleteStudentProfile(Guid id);
    }
}
