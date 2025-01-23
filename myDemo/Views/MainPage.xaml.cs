using myDemo.ViewModels;

namespace myDemo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }

        private void MyCamera_MediaCaptured(object sender, CommunityToolkit.Maui.Views.MediaCapturedEventArgs e)
        {
            //if (Dispatcher.IsDispatchRequired)
            //{
            //    Dispatcher.Dispatch(() => MyImage.Source = ImageSource.FromStream(() => e.Media));
            //    return;
            //}

            MyImage.Source = ImageSource.FromStream(() => e.Media);
            //MyCamera.IsVisible = false;
        }

        private async void Capture_Button_Clicked(object sender, EventArgs e)
        {
            await MyCamera.CaptureImage(CancellationToken.None);
        }
    }

}
