using ArticleProject.Core;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ArticleProject.CoreView
{
    public class AuthorPostView
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Display(Name = "User Id")]
        public string? UserId { get; set; }

        [Display(Name = "User Name")]
        public string? UserName { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "This field is required")]
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
        [Display(Name = "Post Image URL")]
        [DataType(DataType.Upload)]
        public IFormFile? PostImageUrl { get; set; }

        [Display(Name = "Added Date")]
        public DateTime? AddedDate { get; set; }

        //Navigation Area

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
