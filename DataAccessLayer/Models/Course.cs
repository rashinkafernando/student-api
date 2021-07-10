
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Subject1 { get; set; }

        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
        public string Subject4 { get; set; }
        public string Subject5 { get; set; }

    }
}
