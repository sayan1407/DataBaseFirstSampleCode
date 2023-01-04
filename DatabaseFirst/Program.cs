using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        public static PlutoContext context = new PlutoContext();
        static void Main(string[] args)
        {
            // Call a stored procedure
            var courses = context.GetCourses();
            foreach(var c in courses)
            {
                Console.WriteLine(c.Description);
            }
            //Use of Enum
            var course = new Course();
            course.Level = CourseLevel.Intermediatte;
        }
    }
}
