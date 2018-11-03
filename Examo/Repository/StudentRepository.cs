using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Examo.Models;

namespace Examo.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly ExamoDbContext _dbContext;
        public StudentRepository(ExamoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid CreateProfile(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChangesAsync();
            return student.PublicId;
        }

        public Guid UpdateProfile(Student student)
        {
            _dbContext.Entry(student).State = EntityState.Modified;
            _dbContext.SaveChangesAsync();
            return student.PublicId;
        }

        public Student GetProfileByGuid(Guid id)=> _dbContext.Students.FirstOrDefault(x => x.PublicId == id);

        public Student GetProfileById(int id)=> _dbContext.Students.FirstOrDefault(x => x.id == id);

        public List<Student> GetStudents() => _dbContext.Students.ToList();

        public void DeleteStudent(int id)
        {
            // TODO: Need to make it soft delete.
            var student = _dbContext.Students.FirstOrDefault(x => x.id == id);
            if (student == null) return;
            _dbContext.Entry(student).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }
    }
}