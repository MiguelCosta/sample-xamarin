using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFListView
{
    class PluralsightCourse
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return Title;
        }
        public static List<PluralsightCourse> GetCourseList()
        {
            var courseList = new List<PluralsightCourse>();
            courseList.Add(new PluralsightCourse
            {
                Title = "Building Cross Platform Apps with Xamarin Part 1",
                Author = "Jim Wilson"
            });
            courseList.Add(new PluralsightCourse
            {
                Title = "Building Cross Platform Apps with Xamarin Part 2",
                Author = "Jim Wilson"
            });
            courseList.Add(new PluralsightCourse
            {
                Title = "Building Google Glass Apps with c# and Xamarin",
                Author = "Jim Wilson"
            });
            courseList.Add(new PluralsightCourse
            {
                Title = "Android for .NET Developers",
                Author = "Jim Wilson"
            });

            return courseList;
        }
    
    }
    
}
