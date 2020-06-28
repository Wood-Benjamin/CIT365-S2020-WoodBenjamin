using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class CourseAssignment
    {
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        [Display(Name = "Instructor Name")]
        public Instructor Instructor { get; set; }
        [Display(Name = "Course Title")]
        public Course Course { get; set; }
    }
}