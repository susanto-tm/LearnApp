using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReviewPage : ContentPage
	{
		public ReviewPage ()
		{
			InitializeComponent ();

            lblResult.Text = $"Great! You got {App.CurrentGame.GetNumberOfCorrectResponses()} out of {App.CurrentGame.NumberOfQuestions} questions correct";
		}
	}
}