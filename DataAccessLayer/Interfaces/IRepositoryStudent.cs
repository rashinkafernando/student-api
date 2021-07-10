using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepositoryStudent
    {
        public Task<Student> CreateStudent(Student student);
        public IEnumerable<Student> GetStudents();

        public Task<int> UpdateStudent(Student student);
        public Task<int> DeleteStudent(int id);

        public Task<Student> GetStudent(int id);


    }
}
