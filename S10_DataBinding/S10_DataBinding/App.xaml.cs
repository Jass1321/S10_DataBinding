using S10_DataBinding.Services;
using S10_DataBinding.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S10_DataBinding
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
