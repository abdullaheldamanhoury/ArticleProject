using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArticleProject.Core
{
    public class AuthorPost
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "User Id")]
        public string? UserId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [Display(Name = "Category")]
        [DataType(DataType.Text)]
        public string? PostCategory { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Post Title")]
        [DataType(DataType.Text)]
        public string? PostTitle { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Post Description")]
        [DataType(DataType.MultilineText)]
        public string? PostDescription { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Profile Image URL")]
        [DataType(DataType.Upload)]
        public string? PostImageUrl { get; set; }

        [Display(Name = "Added Date")]
        public DateTime? AddedDate { get; set; }

        //Navigation Area

        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
