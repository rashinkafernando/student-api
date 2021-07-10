using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Course { get; set; }
    }
}
