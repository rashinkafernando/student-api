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
    public class CourseController : ControllerBase
    {
        private readonly IRepositoryCourse _course;
        private readonly CourseService _courseService;

        //Dependency injection to the contructor.
        public CourseController(IRepositoryCourse repositoryCourse, CourseService courseService)
        {
            _course = repositoryCourse;
            _courseService = courseService;
        }

        //Add course
        [HttpPost]
        public async Task<Course> AddCourse([FromBody] Course course)
        {
            try
            {
                return await _courseService.AddCourse(course); 
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get all courses
        [HttpGet]
        public IEnumerable<Course> GetAllcourses()
        {
            try
            {
                return _courseService.GetCourses(); //returns all the course objects.
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get a course by id
        [HttpGet("{id}")]
        public async Task<Course> GetCourse(int id)
        {
            try
            {
                return await _courseService.GetCourseById(id); //returns the course object.
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get the course name list
        [HttpGet("CourseNames")]
        public IEnumerable<string> GetCourseNames()
        {
            try
            {
                return _courseService.GetCourseNames(); //returns the course name list.
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Delete a course using id
        // "{id}" is a placeholder variable for the unique identifier of the course.
        // When the course controller is invoked, the value of "{id}" in the URL is passed to id parameter in the method.
        [HttpDelete("{id}")]
        public async Task<int> DeleteCourse(int id)
        {
            try
            {
                return await _courseService.DeleteCourse(id); //uses the delete method in Course service. 1 is retured as the result.

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Update a course by id
        [HttpPut("{id}")]
        public async Task<int> UpdateCourse([FromBody] Course course)
        {
            try
            {
                return await _courseService.UpdateCourse(course); //returns an interger after updating the student.
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
