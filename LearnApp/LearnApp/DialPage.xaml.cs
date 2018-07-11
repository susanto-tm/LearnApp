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
	public partial class DialPage : ContentPage
	{
		public DialPage ()
		{
			InitializeComponent ();
            
		}
        
        public void Button_Clicked(object sender, EventArgs e)
        {
            _number.Text += ((Button)sender).Text;
        }
    }
}