using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Core
{
    public class Author
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
        [Required]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        [Display(Name = "Profile Image URL")]
        public string? ProfileImageUrl { get; set; }
        [Display(Name = "Bio")]
        public string? Bio { get; set; }
        [Display(Name = "Facebook")]
        public string? Facebook { get; set;}
        [Display(Name = "Instagram")]
        public string? Instagram { get; set;}
        [Display(Name = "Twitter")]
        public string? Twitter { get; set;}

        //Navigation
        public virtual List<AuthorPost>? AuthorPosts { get; set; }
    }
}
