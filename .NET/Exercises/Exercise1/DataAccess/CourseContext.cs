using Microsoft.EntityFrameworkCore;
using CourseBackend.Models.DataModels;
namespace CourseBackend.DataAccess
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }

}
