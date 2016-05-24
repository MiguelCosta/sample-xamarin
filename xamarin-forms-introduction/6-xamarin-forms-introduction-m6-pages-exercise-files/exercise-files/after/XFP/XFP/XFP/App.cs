using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFP
{
    public class App
    {
        public static Page GetMainPage()
        {
            //return new CoursePage(PluralsightCourse.GetCourseList().First());
            return new NavigationPage(new HomePage());
        }
    }
}
