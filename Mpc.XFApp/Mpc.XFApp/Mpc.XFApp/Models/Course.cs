using System.Collections.Generic;

namespace Mpc.XFApp.Models
{
    public class Course
    {
        public string Author { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string TitleShort { get; set; }
        public static List<Course> GetCourseList()
        {
            var courseList = new List<Course>();
            courseList.Add(new Course
            {
                Title = "Building Cross Platform Apps with Xamarin Part 1",
                TitleShort = "Xamarin 1",
                Description = "Learn how to use Xamarin to leverage your skills in Microsoft Visual Studio " +
                "and C# to build cross-platform apps that run on both Android and iOS.",
                Author = "Jim Wilson"
            });
            courseList.Add(new Course
            {
                Title = "Building Cross Platform Apps with Xamarin Part 2",
                TitleShort = "Xamarin 2",
                Description = "Learn how to use Xamarin to leverage your skills in Microsoft Visual Studio " +
                "and C# to build cross-platform apps that run on both Android and iOS, and embrace the features " +
                "and capabilities of each platform.",
                Author = "Jim Wilson"
            });
            courseList.Add(new Course
            {
                Title = "Building Google Glass Apps with c# and Xamarin",
                TitleShort = "Xamarin Glass",
                Description = "Learn to develop apps for Google Glass with C# and Xamarin by building a " +
                "full-featured Scavenger Hunt game using the Xamarin Glass Development Kit component.",
                Author = "Jim Wilson"
            });
            courseList.Add(new Course
            {
                Title = "Android for .NET Developers",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Jim Wilson"
            });

            return courseList;
        }

        public override string ToString()
        {
            return $"{Title} | {Author}";
        }
    }
}
