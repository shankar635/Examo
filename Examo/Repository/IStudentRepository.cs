using System;
using System.Collections.Generic;
using Examo.Models;

namespace Examo.Repository
{
    public interface IStudentRepository
    {
        Guid CreateProfile(Student student);
        Guid UpdateProfile(Student student);
        Student GetProfileByGuid(Guid id);
        Student GetProfileById(Int32 id);
        List<Student> GetStudents();
        void DeleteStudent(Int32 id);
    }
}
