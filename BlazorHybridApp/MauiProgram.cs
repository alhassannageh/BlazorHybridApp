using BlazorComponents.Data;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace BlazorHybridApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            //.RegisterBlazorMauiWebView() // Remove this line!
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // builder.Services.AddBlazorWebView(); // You can remove this line
        builder.Services.AddMauiBlazorWebView(); // Add this line
        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}

