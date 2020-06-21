using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "A movie title is required.")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid release date, 'MM/DD/YYYY'.")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"[a-zA-Z0-9@#$%&*+\-_(),+':;?.,![\]\s\\/]+$")]
        [Required(ErrorMessage = "A genre is required.")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(0, 100, ErrorMessage = "Enter $0 for 'Free'.")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "A price is required.")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5), Required(ErrorMessage = "A rating is required.")]
        public string Rating { get; set; }

        [Display(Name = "Image Path")]
        public string UploadPath { get; set; }

        [NotMapped]
        [Display(Name = "Upload Image")]
        public IFormFile UploadImage { get; set; }
    }
}