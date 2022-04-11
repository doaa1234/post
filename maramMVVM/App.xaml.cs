using maramMVVM.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace maramMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            //  MainPage = new NavigationPage(new TempletPageView());
            MainPage=new TempletPageView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
