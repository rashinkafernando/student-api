using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    
   public interface IRepositoryGrade
    {
        public Task<Grade> AddGrade(Grade grade);
        public Task<Grade> GetGrade(string id);
    }
}
