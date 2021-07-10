using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RepositoryStudent : IRepositoryStudent
    {
        ApplicationDbContext _context;
        public RepositoryStudent(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<Student> CreateStudent(Student student)
        {
            try
            {
                var obj = await _context.Students.AddAsync(student);
                _context.SaveChanges();
                return obj.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> DeleteStudent(int id)
        {
            try
            {
                var obj = await _context.Students.FindAsync(id);
                _context.Students.Remove(obj);
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Student> GetStudent(int id)
        {
            try
            {
                return await _context.Students.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public IEnumerable<Student> GetStudents()
        {
            try
            {
                return  _context.Students.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateStudent(Student student)
        {
            try
            {
                var obj = await _context.Students.FindAsync(student);
                _context.Students.Update(obj);
                return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
    }
}
