using Excercise_5.DataAccess;
using Excercise_5.Models.DataModels;

namespace Excercise_5.Services
{
    public class StudentService : IStudentServices
    {
        private readonly ExcerciseContext _dbContext;

        public StudentService(ExcerciseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Student> GetStudentWithoutCourses()
        {
            return _dbContext.Students.Where(s => !s.Courses.Any()).ToList();
        }

        public IEnumerable<Student> GetStudentWithCourses()
        {
            return _dbContext.Students.Where(s => s.Courses.Any()).ToList();
        }
    }
}

