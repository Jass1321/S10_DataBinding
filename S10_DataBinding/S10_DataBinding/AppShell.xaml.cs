using S10_DataBinding.ViewModels;
using S10_DataBinding.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace S10_DataBinding
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
