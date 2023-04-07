using Microsoft.Maui.Controls;
using CommunityToolkit.Maui;

namespace IntegrateX;

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
				fonts.AddFont("Harabara.otf", "Harabara");
				fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
				fonts.AddFont("Roboto-BlackItalic.ttf", "RobotoBlackItalic");
				fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
				fonts.AddFont("Roboto-BoldItalic.ttf", "RobotoBoldItalic");
				fonts.AddFont("Roboto-Italic.ttf", "RobotoItalic");
				fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
				fonts.AddFont("Roboto-LightItalic.ttf", "RobotoLightItalic");
				fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
				fonts.AddFont("Roboto-MediumItalic.ttf", "RobotoMediumItalic");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
				fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
				fonts.AddFont("Roboto-ThinItalic.ttf", "RobotoThinItalic");
			});
		//builder.UseMauiApp<App>()
		//	.Usesharp

		return builder.Build();
	}
}
