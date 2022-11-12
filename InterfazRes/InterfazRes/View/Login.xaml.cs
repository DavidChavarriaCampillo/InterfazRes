//using InterfazRes.Contorl;
using InterfazRes.Modelo;
//using InterfazRes.Servicio;
using InterfazRes.View;
//using InterfazRes.viewModel;
using InterfazRes.ViewModel;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        LoginViewModel context = new LoginViewModel();
        //RegisterServicio servicio = new RegisterServicio();
        //List<RegisterModel> usuariosList= new List<RegisterModel>();
        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = context;
            context.GetUsers();
        }

        private async void regis_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Register());

        }

        private async void log_Clicked(object sender, EventArgs e)
        {
            try
            {
                context.GetUsers();
                RegisterModel user = context.Iniciar();

                if (user.Usuario != null)
                {
                    User.Text = "";
                    Password.Text = "";
                    await Navigation.PushAsync(new MainPage(user));
                }
                else
                {
                    DisplayAlert("Error", "Usuario o Contraseña incorrectos", "Cerrar");
                }

            }
            catch (Exception err)
            {

                DisplayAlert("Error", "Se produjo un error al iniciar la seccion", "Cerrar");

            }

        }
    }
}