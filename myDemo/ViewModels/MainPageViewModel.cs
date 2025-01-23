using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using myDemo.Services;
using CommunityToolkit.Mvvm.Input;

namespace myDemo.ViewModels
{
    public partial class MainPageViewModel(INavigationService navigationService) : BaseViewModel(navigationService)
    {
        INavigationService _navigationService = navigationService;

        public ObservableCollection<IDrawingLine> Lines { get; set; } = [];

        [ObservableProperty]
        public required ImageSource _imageSource;

        [RelayCommand]
        private void ClearSignature()
        {
            Lines.Clear();
        }

        [RelayCommand]
        private void SaveSignature()
        {
            //save to database/cloud
            //then clear the signature
            Lines.Clear();
            //_imageSource = null;
        }
    }
}