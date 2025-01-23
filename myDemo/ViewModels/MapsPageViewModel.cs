using myDemo.Services;

namespace myDemo.ViewModels
{
    public partial class MapsPageViewModel : BaseViewModel
    {
        public MapsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}