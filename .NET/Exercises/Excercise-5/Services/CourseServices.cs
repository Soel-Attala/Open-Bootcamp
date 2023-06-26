using Excercise_5.DataAccess;
using Excercise_5.Models.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace Excercise_5.Services
{
    public class CourseService : ICourseService
    {
        private readonly ExcerciseContext _dbContext;

        public CourseService(ExcerciseContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _dbContext.Courses.ToList();
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            return _dbContext.Courses.Where(c => c.Categories.Any(cat => cat.Id == categoryId)).ToList();
        }

        public IEnumerable<Course> GetCoursesWithoutChapters()
        {
            return _dbContext.Courses.Where(c => !_dbContext.Chapters.Any(ch => ch.CourseId == c.Id)).ToList();
        }

        public IEnumerable<Chapter> GetChaptersByCourse(int courseId)
        {
            return _dbContext.Chapters.Where(ch => ch.CourseId == courseId).ToList();
        }

        public IEnumerable<Student> GetStudentsByCourse(int courseId)
        {
            return _dbContext.Students.Where(s => s.Courses.Any(c => c.Id == courseId)).ToList();
        }
    }
}
