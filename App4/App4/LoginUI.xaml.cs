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

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(Entry_Username.Text == "admin" && Entry_Password.Text == "123")
            {
                DisplayAlert("Welcome Back", Entry_Username.Text, "Ok");
                Navigation.PushAsync(new RegisterPage());
            }
            else if (Entry_Username.Text == "" && Entry_Password.Text == "")
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