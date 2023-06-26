using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Excercise_5.DataAccess;
using Excercise_5.Models.DataModels;
using Excercise_5.Services;

namespace Excercise_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ExcerciseContext _context;
        //services
        private readonly ICourseService _courseService;

        public CoursesController(ExcerciseContext context, ICourseService courseService)
        {
            _context = context;

            _courseService = courseService;
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            if (_context.Courses == null)
            {
                return NotFound();
            }
            return await _context.Courses.ToListAsync();
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            if (_context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        [HttpGet("courses/category/{categoryId}")]
        public IActionResult GetCoursesByCategory(int categoryId)
        {
            var courses = _courseService.GetCoursesByCategory(categoryId);
            return Ok(courses);
        }

        [HttpGet("courses/withoutchapters")]
        public IActionResult GetCoursesWithoutChapters()
        {
            var courses = _courseService.GetCoursesWithoutChapters();
            return Ok(courses);
        }

        [HttpGet("courses/{courseId}/chapters")]
        public IActionResult GetChaptersByCourse(int courseId)
        {
            var chapters = _courseService.GetChaptersByCourse(courseId);
            return Ok(chapters);
        }

        [HttpGet("courses/{courseId}/students")]
        public IActionResult GetStudentsByCourse(int courseId)
        {
            var students = _courseService.GetStudentsByCourse(courseId);
            return Ok(students);
        }




        // PUT: api/Courses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Courses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            if (_context.Courses == null)
            {
                return Problem("Entity set 'ExcerciseContext.Courses'  is null.");
            }
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            if (_context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseExists(int id)
        {
            return (_context.Courses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
