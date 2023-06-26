using Excercise_5.Models.DataModels;
using System.Collections.Generic;

namespace Excercise_5.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
        IEnumerable<Course> GetCoursesByCategory(int categoryId);
        IEnumerable<Course> GetCoursesWithoutChapters();
        IEnumerable<Chapter> GetChaptersByCourse(int courseId);
        IEnumerable<Student> GetStudentsByCourse(int courseId);
    }



    public interface IStudentServices
    {
        IEnumerable<Student> GetStudentWithoutCourses();
        IEnumerable<Student> GetStudentWithCourses();
    }
}

