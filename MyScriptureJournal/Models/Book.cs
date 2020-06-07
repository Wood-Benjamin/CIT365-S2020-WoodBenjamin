using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace MyScriptureJournal.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Book name is required.")]
        public string BookName { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a valid date, 'MM/DD/YYYY'.")]
        public DateTime DateAdded { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Required(ErrorMessage = "A chapter Number is required.")]
        public int Chapter { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        [Required(ErrorMessage = "A verse Number is required.")]
        public int Verse { get; set; }

        [RegularExpression(@"^.+")]
        [StringLength(255)]
        [Required(ErrorMessage = "A Note is required, Max 255 Characters.")]
        public string Note { get; set; }
    }
}
