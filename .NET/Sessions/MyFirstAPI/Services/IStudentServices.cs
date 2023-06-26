using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Services
{
    public interface IStudentServices
    {
        IEnumerable<Student> GetStudentWithOutCourses();
        IEnumerable<Student> GetStudentWithCourses();

    }
}
