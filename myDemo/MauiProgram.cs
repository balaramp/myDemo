using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using myDemo.Services;
using myDemo.ViewModels;


namespace myDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitCamera()
                .UseMauiCommunityToolkit()
//#if !WINDOWS
//                .UseMauiMaps()
//#endif
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MapsPageViewModel>();
            builder.Services.AddSingleton<SignaturePageViewModel>();
            builder.Services.AddSingleton<CameraPageViewModel>();

            builder.Services.AddSingleton<INavigationService, MauiNavigationService>();
            builder.Services.AddSingleton<IRequestProvider, RequestProvider>();

            return builder.Build();
        }
    }
}
