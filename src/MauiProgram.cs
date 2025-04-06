using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Platform;
using src.Services;
using src.ViewModels;
using src.Views;

namespace src;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("PlayfairDisplay-VariableFont_wght.ttf", "TitleFontRegular");
                fonts.AddFont("Philosopher-Bold.ttf", "TitlePhilosopherBold");
                fonts.AddFont("Bookseller-Regular.otf", "BooksellerRegular");
                fonts.AddFont("Bookseller-RegularBold.otf", "BooksellerRegularBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<BookViewModel>();
        builder.Services.AddTransient<AuthService>();
        builder.Services.AddTransient<LoadingView>();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CustomEntry", (handler, view) =>
        {

#if ANDROID
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif

        });

        return builder.Build();
	}
}
