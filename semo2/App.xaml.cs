using semo2.Views.Productos;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 

using semo2.Views.Home;
namespace semo2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new N
            MainPage = new VHPrincipal();
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
