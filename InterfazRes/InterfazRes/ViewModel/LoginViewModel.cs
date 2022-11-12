using InterfazRes.Modelo;
using InterfazRes.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace InterfazRes.ViewModel
{
    public class LoginViewModel : LoginModel
    {
        RegisterServicio servicio = new RegisterServicio();
        List<RegisterModel> usuarios = new List<RegisterModel>();
        LoginModel model;
        public async Task GetUsers()
        {
            usuarios = await servicio.GetUsuarios();
        }

        public RegisterModel Iniciar()
        {
            RegisterModel user =new RegisterModel();
            model = new LoginModel()
            {
                Usuario = Usuario,
                Contracena = Contracena
            };
            foreach(var usuario in usuarios) 
            {
                if(usuario.Usuario == model.Usuario && usuario.Contracena == model.Contracena)
                {
                    user= usuario;
                    break;
                }
            }

            return user;
        }

        /*public void Limpiar()
        {
            Usuario = "";
            Contracena = "";
        }*/
    }
}
