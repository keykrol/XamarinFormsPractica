using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormPractica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Primera_practica();
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
