using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3AGuadalupe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana2 : ContentPage
    {
        
        public Ventana2(string user, string pass)
        {
            InitializeComponent();

            lbluser.Text = user;
            txtPass.Text = pass;
        }
    }
}