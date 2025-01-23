using CommunityToolkit.Mvvm.ComponentModel;
using myDemo.Services;

namespace myDemo.ViewModels
{
    public partial class BaseViewModel :ObservableObject
    {
        protected readonly INavigationService NavigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
