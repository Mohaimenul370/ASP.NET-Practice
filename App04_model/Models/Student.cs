using System.ComponentModel.DataAnnotations;

namespace App04_model.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(150), Display(Name ="Student Name")]
        public string stdName { get; set; }

        
        public string? stdEmail { get; set; }

        [Required, StringLength(100),Display(Name ="Mobile Number")]
        public string stdMobile { get; set; }
    }
}
