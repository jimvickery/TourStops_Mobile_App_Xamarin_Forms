using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TourStops_MultiPF.ContentPages
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }


        public void ShowDetailsButton_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new DetailsPage());
        }


        public void ShowTilesButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TitlePage());
        }

        public void ShowScheduleButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulePage());
        }
            
    }
}
