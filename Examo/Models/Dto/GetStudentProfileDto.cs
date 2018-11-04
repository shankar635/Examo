using System;

namespace Examo.Models.Dto
{
    public class GetStudentProfileDto
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string ProfilePic { get; set; }
        public string Description { get; set; }
        private Guid PublicId { get; set; }
        public bool IsActive { get; set; }
    }
}