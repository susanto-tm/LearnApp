using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace LearnApp.AutomatedUITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
            app = ConfigureApp.Android
                .ApkFile(@"C:\Users\Timothy\source\repos\LearnApp\LearnApp\LearnApp.Android\bin\Release\com.companyname.LearnApp.apk")
                .StartApp();

        }

        [Test]
        public void AppLaunches()
        {
            app.Repl();
            app.Screenshot("First Screen.");
        }

		[Test]
		public void WelcomeTextIsDisplayed()
		{
            
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
			app.Screenshot("Welcome screen.");

			Assert.IsTrue(results.Any());
		}
	}
}
