﻿using Xamarin.Forms;

namespace Mpc.XFApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new MyPage();
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
