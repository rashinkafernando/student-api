using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    //Define business logic in this class.
    public class StudentService
    {
        private readonly IRepositoryStudent _student;

        public StudentService(IRepositoryStudent student)
        {
            _student = student;
        }

        //Add Student
        public async Task<Student> AddStudent(Student student)
        {
            try
            {
                return await _student.CreateStudent(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get all students
        public IEnumerable<Student> GetAllStudents()
        {
            try
            {
                return _student.GetStudents().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get student by Id
        public async Task<Student> GetStudentById(int id)
        {
            try
            {
                return await _student.GetStudent(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Update student
        public async Task<int> UpdateStudent(Student student)
        {
            try
            {
                return await _student.UpdateStudent(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Delete student
        public async Task<int> DeleteStudent(int id)
        {
            try
            {
                return await _student.DeleteStudent(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
