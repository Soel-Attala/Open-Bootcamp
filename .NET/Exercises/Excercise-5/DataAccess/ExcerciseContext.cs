using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Excercise_5.Models.DataModels;

namespace Excercise_5.DataAccess
{
    public class ExcerciseContext : DbContext
    {
        public ExcerciseContext(DbContextOptions<ExcerciseContext> options) : base(options)
        {

        }
        //TODO: add DBSets (tables of our database)

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}

