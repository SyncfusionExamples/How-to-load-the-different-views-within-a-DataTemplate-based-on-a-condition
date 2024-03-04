using System.Globalization;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Track_Order_Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Track Order", "Order is shipped", "OK");

        }

        private async void Check_Details_Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Shipping Details", "The order will be shipped soon", "OK");
        }
    }

    public class DetailsTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? TrackOrderButton { get; set; }

        public DataTemplate? CheckDetailsButton { get; set; }

        protected override DataTemplate? OnSelectTemplate(object item, BindableObject container)
        {
            bool value = ((OrderInfo)item).IsShipped;

            return value ? TrackOrderButton : CheckDetailsButton;
        }
    }
}
