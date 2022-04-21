using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gorosk
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new horosk();
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
