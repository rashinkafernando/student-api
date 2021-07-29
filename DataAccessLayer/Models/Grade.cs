using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    /**
     * Model class for student's grade.
     * It will contain the grades for each subject of the student.
     */
    public class Grade
    {
        [Key]
        public string studentID { get; set; }
        public string courseName { get; set; }
        public int subject1 { get; set; }
        public int subject2 { get; set; }
        public int subject3 { get; set; }
        public int subject4 { get; set; }
        public int subject5 { get; set; }
    }
}
