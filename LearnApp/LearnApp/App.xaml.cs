using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Collections.Generic;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace LearnApp
{
	public partial class App : Application
	{
        public static Game CurrentGame { get; private set; }
		public App ()
		{
			InitializeComponent();
            //Root Page of Application
            MainPage = new NavigationPage(new HomePage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            string questionsText = string.Empty;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            using (var stream = assembly.GetManifestResourceStream("LearnApp.Data.questions.json"))
            {
                questionsText = new StreamReader(stream).ReadToEnd();
            }

            var questions = JsonConvert.DeserializeObject<List<QuizQuestion>>(questionsText);

            CurrentGame = new Game(questions);
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
