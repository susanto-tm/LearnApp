using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnApp
{
	public partial class HomePage : ContentPage
	{

        public HomePage()
		{
			InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
		}

        async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionPage());
        }
    }
}
