using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RepositoryCourse : IRepositoryCourse
    {
        ApplicationDbContext _context;
        public RepositoryCourse(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Course> CreateCourse(Course course)
        {
            try
            {
               var obj = await _context.Courses.AddAsync(course);
                _context.SaveChanges();
                return obj.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> DeleteCourse(int id)
        {
            try
            {
                var obj = await _context.Courses.FindAsync(id);
                _context.Courses.Remove(obj);
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Course> GetAllCourses()
        {
            try
            {
                return _context.Courses.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Course> GetCourse(int id)
        {
            try
            {
                return await _context.Courses.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateCourse(Course course)
        {
            try
            {
                var obj = await _context.Courses.FindAsync(course);
                _context.Courses.Update(course);
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
