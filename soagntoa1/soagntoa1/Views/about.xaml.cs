using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("#");
        }
    }
}