using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana3AGuadalupe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrirVentana2_Clicked(object sender, EventArgs e)
        {

            string user = txtUser.Text;
            string pass = txtPassword.Text;

            string user_val = "uisrael";
            string pass_val = "uisrael2020";

            if (user == user_val && pass==pass_val)
            {
                await Navigation.PushAsync(new Ventana2(user, pass));
            }
            else
            {
                await DisplayAlert("Login Incorrecto", "Datos incorrectos", "Volver");
            }
            

            
        }
    }
}
