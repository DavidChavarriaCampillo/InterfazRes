using InterfazRes.Contorl;
using InterfazRes.Modelo;
using InterfazRes.Servicio;
using InterfazRes.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterfazRes.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        //List<RegisterViewModel> usuarios = new List<RegisterViewModel>();
        //AlmacenDatos alm = new AlmacenDatos();
        RegisterViewModel context = new RegisterViewModel();
        List<RegisterModel> usuarios = new List<RegisterModel>();
        RegisterServicio servicio= new RegisterServicio();
        RegisterModel model;
        bool cond = false;
        public Register()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = context;
        }

        private async void btn_Registrar_Clicked(object sender, EventArgs e)
        {
            usuarios = await servicio.GetUsuarios();
            foreach(RegisterModel usuario in usuarios) 
            {
                if(usuario.Documento == documento.Text || usuario.Usuario == user.Text || usuario.Email == email.Text)
                {
                    cond = true;
                }
            }

            if (cond)
            {
                DisplayAlert("Error", "El usuario ya exixste", "Cerrar");
            }
            else
            {
                DisplayAlert("Felicidades", "Usuario creado exitosamente", "Aceptar");
                await Navigation.PushAsync(new Login());
                await context.Guardar();
            }  
        }
    }
}