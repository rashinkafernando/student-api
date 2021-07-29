using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RepositoryGrade : IRepositoryGrade
    {
        ApplicationDbContext _context;

        public RepositoryGrade(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<Grade> AddGrade(Grade grade)
        {
            try
            {
                var obj = await _context.Grades.AddAsync(grade);
                _context.SaveChanges();
                return obj.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Grade> GetGrade(string id)
        {
            try
            {
                Grade grade = await _context.Grades.FindAsync(id); //Find the grade record using student id
                return grade; //return it after that.
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
