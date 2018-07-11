using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace LearnApp.AutomatedUITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp.Android
                    .ApkFile(@"C:\Users\Timothy\source\repos\LearnApp\LearnApp\LearnApp.Android\bin\Release\com.companyname.LearnApp.apk")
                    .StartApp();
			}
			return ConfigureApp.iOS.StartApp();
		}
	}
}