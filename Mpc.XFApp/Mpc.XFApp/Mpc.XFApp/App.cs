using Xamarin.Forms;

namespace Mpc.XFApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new MyPage();
            //MainPage = new XFListViewPage1();
            //MainPage = new XFListViewPage2();
            //MainPage = new XFListViewPage3();
            MainPage = new Pages.XFPage2();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}
