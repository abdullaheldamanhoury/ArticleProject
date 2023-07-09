using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Core
{
    public class Category
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [Display(Name="Category Name")]
        [MaxLength(50,ErrorMessage = "Max length for input is 50 character")]
        [MinLength(2, ErrorMessage = "Min length for input is 2 character")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        //Navigation
        public virtual List<AuthorPost>? AuthorPosts { get; set; }
    }
}
