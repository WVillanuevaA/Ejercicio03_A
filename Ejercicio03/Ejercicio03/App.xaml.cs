using System;
using Ejercicio03.Services;
using Ejercicio03.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new MainPage());
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
