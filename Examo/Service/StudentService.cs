using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Examo.Models.Dto;
using Examo.Repository;
using System.Net.Http;
using System.Web.Http.ModelBinding;
using Examo.Models;

namespace Examo.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentService : IStudentService
    {
        private ModelStateDictionary _modelState;
        private readonly StudentRepository _studentRepository;
        /// <summary>
        /// Student Service
        /// </summary>
        /// <param name="studentRepository"></param>
        /// <param name="modelState"></param>
        public StudentService(StudentRepository studentRepository, ModelStateDictionary modelState)
        {
            _studentRepository = studentRepository;
            _modelState = modelState;
        }
        /// <summary>
        /// Validation
        /// </summary>
        /// <param name="studentProfile"></param>
        /// <returns></returns>
        protected bool ValidateProduct(CreateStudentProfileDto studentProfile)
        {
            if (studentProfile == null)
            {
                _modelState.AddModelError("Student Profile", "Invalid Data.");
            }
            else
            {
                if (studentProfile.Name.Trim().Length == 0)
                    _modelState.AddModelError("Name", "Name is required.");
                if (studentProfile.EmailId.Trim().Length == 0)
                    _modelState.AddModelError("EmailId", "Email Id is required.");
                if (studentProfile.ContactNo.Trim().Length == 0)
                    _modelState.AddModelError("ContactNo", "Contact No. is required.");
                if (studentProfile.Password.Trim().Length == 0)
                    _modelState.AddModelError("Password", "Password is required.");
            }
            return _modelState.IsValid;
        }

        /// <summary>
        /// Create Profile
        /// </summary>
        /// <param name="studentProfile"></param>
        /// <returns></returns>
        public Guid CreateProfile(CreateStudentProfileDto studentProfile)
        {
            if (ValidateProduct(studentProfile))
            {
                var student = new Student
                {
                    Name = studentProfile.Name,
                    Password = studentProfile.Password,
                    ProfilePic = studentProfile.ProfilePic,
                    PublicId = Guid.NewGuid(),
                    Description = studentProfile.Description,
                    IsActive = true,
                    EmailId = studentProfile.EmailId,
                    ContactNo = studentProfile.ContactNo
                };
                _studentRepository.CreateProfile(student);
                return student.PublicId;
            }
            else
            {
                return Guid.Empty;
            }
        }

        public Guid UpdateProfile(UpdateStudentProfileDto studentProfile)
        {
            throw new NotImplementedException();
        }

        public GetStudentProfileDto GetStudentByGuid(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<GetStudentProfileDto> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void DeleteStudentProfile(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}