namespace Examo.Models.Dto
{
    public class CreateStudentProfileDto : GetStudentProfileDto
    {
        public string Password { get; set; }
    }
}