using BusinessLayer.Services;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepositoryStudent repositoryStudent;
        private readonly StudentService service;

        public StudentController(IRepositoryStudent student, StudentService studentService)
        {
            repositoryStudent = student;
            service = studentService;
        }

        //Add Student
        //[HttpPost("AddStudent")]
        [HttpPost]
        public async Task<Student> AddStudent([FromBody] Student student)
        {
            try
            {
                return await service.AddStudent(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get all students
        [HttpGet]
        public IEnumerable<Student> GetAllStudents()
        {
            try
            {
                return service.GetAllStudents(); //student list is returned.
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get a student using id
        [HttpGet("{id}")]
        public async Task<Student> GetStudent(int id)
        {
            try
            {
                return await service.GetStudentById(id); //returns student object.
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Delete a student using id
        // "{id}" is a placeholder variable for the unique identifier of the student.
        // When the student controller is invoked, the value of "{id}" in the URL is passed to id parameter in the method.
        [HttpDelete("{id}")] 
        public async Task<int> DeleteStudent(int id)
        {
            try
            {
                return await service.DeleteStudent(id); //uses the delete method in Student service. 1 is retured as the result.

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Update a student by id
        [HttpPut("{id}")]
        public async Task<int> UpdateStudent([FromBody] Student student)
        {
            try
            {
                return await service.UpdateStudent(student); //returns an interger after updating the student.
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
