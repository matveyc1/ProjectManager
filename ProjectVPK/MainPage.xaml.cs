namespace ProjectVPK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void StatsRoom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StatsRoom());
        }

        private async void PlanRoom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlanRoom());
        }

        private async void FileRoom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FileRoom());
        }

        private async void MessageRoom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync (new MessageRoom());
        }
    }

}
