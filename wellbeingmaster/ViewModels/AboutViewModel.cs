using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace wellbeingmaster.ViewModels
{
    public class AboutViewModel  
    {
        public AboutViewModel()
        {
               OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}