using System;

namespace Examo.Models.Dto
{
    public class UpdateStudentProfileDto : GetStudentProfileDto
    {
        public Guid PublicId { get; set; }
    }
}