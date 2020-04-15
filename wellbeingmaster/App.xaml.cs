using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Ioc;
using wellbeingmaster.Views;
using Xamarin.Essentials;
using wellbeingmaster.Style;

namespace wellbeingmaster
{
    public partial class App : Application
    {
        public static AppTheme AppTheme { get; set; }

        public App()
        {
            InitializeComponent();

             MainPage = new AppShell();
            ThemeHelper.ChangeTheme(Theme.Default, true);
        }

        public static void ApplyTheme()
        {
           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {

            ThemeHelper.ChangeTheme(Settings.ThemeOption, true);
        }
    }
}
