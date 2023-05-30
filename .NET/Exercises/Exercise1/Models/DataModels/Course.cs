using System.ComponentModel.DataAnnotations;


namespace CourseBackend.Models.DataModels
{
    public enum CourseLevel
    {
        Basico,
        Intermedio,
        Avanzado
    }
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required, StringLength(600)]
        public string LongDescription { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string TargetAudience { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string Objectives { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public CourseLevel Level { get; set; }

    }
}
