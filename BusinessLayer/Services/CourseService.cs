using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CourseService
    {
        private readonly IRepositoryCourse _course;

        public CourseService(IRepositoryCourse course)
        {
            _course = course;
        }

        //Add course
        public async Task<Course> AddCourse(Course course)
        {
            try
            {
                return await _course.CreateCourse(course);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get all courses
        public IEnumerable<Course> GetCourses()
        {
            try
            {
                return _course.GetAllCourses().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get course by Id
        public async Task<Course> GetCourseById(int id)
        {
            try
            {
                return await _course.GetCourse(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Get all course names
        public IEnumerable<string> GetCourseNames()
        {
            try
            {
                IEnumerable<string> CourseNames = _course.GetAllCourses().Select(c => c.CourseName).ToList();
                return CourseNames;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //update course
        public async Task<int> UpdateCourse(Course course)
        {
            try
            {
                return await _course.UpdateCourse(course);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Delete course
        public async Task<int> DeleteCourse(int id)
        {
            try
            {
                return await _course.DeleteCourse(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
