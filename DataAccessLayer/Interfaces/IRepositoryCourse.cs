using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepositoryCourse
    {
        public Task<Course> CreateCourse(Course course);
        public IEnumerable<Course> GetAllCourses();
        public Task<int> UpdateCourse(Course course);
        public Task<int> DeleteCourse(int id);
        public Task<Course> GetCourse(int id);
    }
}
