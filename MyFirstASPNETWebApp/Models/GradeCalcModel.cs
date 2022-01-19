using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0,100)]
        public int Assignments { get; set; }

        [Required]
        [Range(0, 100)]
        public int GroupProject { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quizzes { get; set; }

        [Required]
        [Range(0, 100)]
        public int Exams { get; set; }

        [Required]
        [Range(0, 100)]
        public int Intex { get; set; }
    }
}