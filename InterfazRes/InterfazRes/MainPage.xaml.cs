using InterfazRes.Modelo;
using InterfazRes.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InterfazRes
{
    public partial class MainPage : ContentPage
    {

        RegisterServicio servicio = new RegisterServicio();
        List<RegisterModel> usuarios = new List<RegisterModel>();

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            Task.Run(RotateImage);
        }

        public MainPage(RegisterModel user)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            Task.Run(RotateImage);
            GetUsers();
            Mensaje.Text = "Bienvenido " + user.Usuario;
        }

        public async Task GetUsers()
        {
            usuarios = await servicio.GetUsuarios();
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(369, 10000, Easing.Linear);
            }
        }
    }
}
