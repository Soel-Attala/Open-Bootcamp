using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Excercise_4
{
    public class Services
    {
        static public void MultipleSelect()
        {

            var enterprises = new[]
            {
                new Enterprise()
                {
                    Id = 1,
                    Name = "Enterprise 1",
                    Employees = new[]
                    {
                        new Employee()
                        {
                            Id=1,
                            Name = "Martin",
                            Email = "Martin123@gmail.com",
                            Salary = 1000
                        },
                        new Employee()
                        {
                            Id=2,
                            Name = "Juanjo",
                            Email = "Juanjo123@gmail.com",
                            Salary = 1100
                        },
                        new Employee()
                        {
                            Id=3,
                            Name = "Jorge",
                            Email = "Jorge123@gmail.com",
                            Salary = 1500
                        },
                        new Employee()
                        {
                            Id=4,
                            Name = "Maria",
                            Email = "Maria123@gmail.com",
                            Salary = 1200
                        },
                    }
                },
                new Enterprise()
                {
                    Id = 2,
                    Name = "Enterprise 2",
                    Employees =new[]
                    {
                        new Employee()
                        {
                            Id=5,
                            Name = "Marisa",
                            Email = "Marisa123@gmail.com",
                            Salary = 1500
                        },
                        new Employee()
                        {
                            Id=6,
                            Name = "Juana",
                            Email = "juanita456@gmail.com",
                            Salary = 1700
                        },
                        new Employee()
                        {
                            Id=7,
                            Name = "Nestor",
                            Email = "Nestor789@gmail.com",
                            Salary = 1400
                        },
                        new Employee()
                        {
                            Id=8,
                            Name = "Alberto",
                            Email = "AlbertitoInflacion@gmail.com",
                            Salary = 4000
                        },
                    }
                }
            };

            //1. Search users by email.
            var emailBuscado = "Martin123@gmail.com";

            var usuariosEncontrados = enterprises
                .SelectMany(e => e.Employees) // Obtener todos los empleados de todas las empresas
                .Where(emp => emp.Email == emailBuscado); // Filtrar por correo electrónico

            foreach (var usuario in usuariosEncontrados)
            {
                Console.WriteLine("Usuario encontrado:");
                Console.WriteLine("Nombre: " + usuario.Name);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Salario: " + usuario.Salary);
                Console.WriteLine();
            }


        }


        static public void SearchStudents()
        {
            var courses = new[]
            {
                new Course()
                {
                    Id = 1,
                    Name = ".NET Intermediate",
                    Level = Course.CourseLevel.Intermediate,
                    Category = "Software Development",
                    Students = new[]
                    {
                        new Student()
                        {
                            Id=1,
                            Name = "Martin",
                            Email = "Martin123@gmail.com",
                            Age = 20,
                            Course = ".NET Intermediate"
                        },
                        new Student()
                        {
                            Id=2,
                            Name = "Juanjo",
                            Email = "Juanjo123@gmail.com",
                            Age = 19,
                            Course = ".NET Intermediate"
                        },
                        new Student()
                        {
                            Id=3,
                            Name = "Jorge",
                            Email = "Jorge123@gmail.com",
                            Age = 17,
                            Course = ".NET Intermediate"
                        },
                        new Student()
                        {
                            Id=4,
                            Name = "Maria",
                            Email = "Maria123@gmail.com",
                            Age = 18,
                            Course = ".NET Intermediate"
                        },
                    }
                },
                new Course()
                {
                    Id = 2,
                    Name = ".NET Advanced",
                    Capacity = 30,
                    Level = Course.CourseLevel.Advanced,
                    Category = "Software Development",
                    Students =new[]

                    {
                        new Student()
                        {
                            Id=5,
                            Name = "Marisa",
                            Email = "Marisa123@gmail.com",
                            Age = 19,
                            Course = ".NET Advanced"
                        },
                        new Student()
                        {
                            Id=6,
                            Name = "Juana",
                            Email = "juanita456@gmail.com",
                            Age = 17,
                            Course = ".NET Advanced"
                        },
                        new Student()
                        {
                            Id=7,
                            Name = "Nestor",
                            Email = "Nestor789@gmail.com",
                            Age = 18,
                            Course = ".NET Advanced"
                        },
                        new Student()
                        {
                            Id=8,
                            Name = "Alberto",
                            Email = "AlbertitoInflacion@gmail.com",
                            Age = 16,
                            Course = ".NET Advanced"
                        },
                    }
                }
            };

            //2.Search student by age +18
            bool ageMoreThan18 =
                courses.Any(course => course.Students.Any(student => student.Age >= 18));

            var studentsAbove18 = courses.SelectMany(course => course.Students)
                             .Where(student => student.Age >= 18);

            foreach (var student in studentsAbove18)
            {
                Console.WriteLine("Student: " + student.Name);
                Console.WriteLine("Email: " + student.Email);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Course: " + student.Course);
                Console.WriteLine();
            }


            //3.students who have at least 1 course
            bool anyCourse =
                courses.Any(course => course.Students.Any(student => student.Course != null));

            var studentsWithCourses = courses.SelectMany(course => course.Students)
                                .Distinct();

            foreach (var student in studentsWithCourses)
            {
                Console.WriteLine("Student: " + student.Name);
                Console.WriteLine("Email: " + student.Email);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Courses:");

                var studentCourses = courses.Where(course => course.Students.Contains(student));

                foreach (var course in studentCourses)
                {
                    Console.WriteLine("- " + course.Name);
                }

                Console.WriteLine();
            }

            //4. Search for courses at a given level that have at least one student enrolled.
            Course.CourseLevel determinatedLevel = Course.CourseLevel.Intermediate;

            var courseWithStudents = courses.Where(c => c.Level == determinatedLevel && c.Students.Any());

            foreach (var course in courseWithStudents)
            {
                Console.WriteLine("Curso: " + course.Name);
                Console.WriteLine("Alumnos:");
                foreach (var student in course.Students)
                {
                    Console.WriteLine("- " + student.Name);
                }
                Console.WriteLine();
            }


            //5. Search for courses of a given level that are of a given category
            Course.CourseLevel targetLevel = Course.CourseLevel.Intermediate; // Specify the target level
            string targetCategory = "Programming"; // Specify the target category

            var matchingCourses = courses.Where(course => course.Level == targetLevel && course.Category == targetCategory);

            foreach (var course in matchingCourses)
            {
                Console.WriteLine("Course: " + course.Name);
                Console.WriteLine("Level: " + course.Level);
                Console.WriteLine("Category: " + course.Category);
                Console.WriteLine();
            }


            //6.Search for courses without students
            var coursesWithoutStudents = courses.Where(course => !course.Students.Any());

            foreach (var course in coursesWithoutStudents)
            {
                Console.WriteLine("Course: " + course.Name);
                Console.WriteLine("Level: " + course.Level);
                Console.WriteLine("Capacity: " + course.Capacity);
                Console.WriteLine("Students: None");
                Console.WriteLine();
            }

        }
    }
}