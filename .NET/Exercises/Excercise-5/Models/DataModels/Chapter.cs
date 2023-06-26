using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace Excercise_5.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        [Required]
        public string List = string.Empty;
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public virtual Course Course { get; set; } = new Course();

    }
}
