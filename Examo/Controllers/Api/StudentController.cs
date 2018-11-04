using System.Net;
using System.Net.Http;
using System.Web.Http;
using Examo.Models.Dto;
using Examo.Service;

namespace Examo.Controllers.Api
{
    /// <inheritdoc />
    /// <summary>
    /// Student Controller
    /// </summary>
    public class StudentController : ApiController
    {
        private readonly StudentService _studentService;
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="studentService"></param>
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        /// <summary>
        /// Create Student Profile
        /// </summary>
        /// <param name="studentProfile"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("~/api/Student/Profile/Create")]
        public HttpResponseMessage CreateStudentProfile(CreateStudentProfileDto studentProfile)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _studentService.CreateProfile(studentProfile));
        }


    }
}
