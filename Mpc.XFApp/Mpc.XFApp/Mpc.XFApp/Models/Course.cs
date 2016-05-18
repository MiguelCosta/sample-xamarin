using System.Collections.Generic;

namespace Mpc.XFApp.Models
{
    public class Course
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public static List<Course> GetCourseList()
        {
            var courses = new List<Course>
            {
                new Course { Author = "Miguel Costa", Title = "Apps with interactions that require native behavior" },
                new Course { Author = "João Carvalho", Title = "Apps that require little platform-specific functionality" },
                new Course { Author = "Miguel Costa", Title = "Xamarin.iOS & Xamarin.Android are best" },
                new Course { Author = "Miguel Costa", Title = "Xamarin.Forms is best" },
                new Course { Author = "João Carvalho", Title = "https://www.xamarin.com/forms" },
                new Course { Author = "Nuno Antunes", Title = "What’s in the box" }
            };

            return courses;
        }

        public override string ToString()
        {
            return $"{Title} | {Author}";
        }
    }
}
