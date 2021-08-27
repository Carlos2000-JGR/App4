using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        

        public LoginUI()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            if(usernameEntry.Text == "admin" && passwordEntry.Text == "123")
            {
                DisplayAlert("Welcome Back", usernameEntry.Text, "Ok");
                Navigation.PushAsync(new MainPage());
            }
            else if (usernameEntry.Text == null && passwordEntry.Text == null)
            {
                DisplayAlert("Oops..", "Both fields have to be filled out", "Ok");
            }

            else 
            {
                DisplayAlert("Oops..", "Username or Password is incorrect", "Ok");
            }

            


        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}