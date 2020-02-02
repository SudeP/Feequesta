using Feequesta.Elements.Views;
using Feequesta.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Feequesta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HeaderAndFooterPager();
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
