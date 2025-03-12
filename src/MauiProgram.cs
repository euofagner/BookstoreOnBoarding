using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
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
			});

		builder.Services.AddTransient<BookViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
