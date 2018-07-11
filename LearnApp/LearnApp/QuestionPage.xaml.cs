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
	public partial class QuestionPage : ContentPage
	{
        Game game;
		public QuestionPage ()
		{
            game = App.CurrentGame;
			InitializeComponent ();
            InitializeControls ();
		}
        void InitializeControls()
        {
            btnTrue.Clicked += (s, e) => OnAnswer(true);
            btnFalse.Clicked += (s, e) => OnAnswer(false);

            btnNext.Clicked += BtnNext_Clicked;

            ResetUI();
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            if (game.NextQuestion() == true)
            {
                ResetUI();
            }
            else {
                this.Navigation.PushAsync(new ReviewPage());
            }
        }

        void ResetUI()
        {
            lblQuestion.Text = game.CurrentQuestion.Question;
            lblResponse.Text = "";

            btnTrue.IsEnabled = true;
            btnFalse.IsEnabled = true;
            btnNext.IsEnabled = false;
        }

        void OnAnswer(bool answer)
        {
            if (answer == true)
            {
                game.OnTrue();
            }
            else {
                game.OnFalse();
            }

            lblResponse.Text = game.CurrentResponse == game.CurrentQuestion.Answer ? "Correct" : "Incorrect";

            btnTrue.IsEnabled = false;
            btnFalse.IsEnabled = false;
            btnNext.IsEnabled = true;
        }
	}
}