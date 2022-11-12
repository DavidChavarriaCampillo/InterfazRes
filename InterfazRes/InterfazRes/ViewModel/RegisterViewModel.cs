using InterfazRes.Modelo;
using InterfazRes.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    public class RegisterViewModel:RegisterModel
    {
        RegisterServicio servicio = new RegisterServicio();
        RegisterModel model;

        public async Task Guardar()
        {
            Guid IdPersona = Guid.NewGuid();
            model = new RegisterModel()
            {
                Id = IdPersona.ToString(),
                Documento = Documento,
                Nombre = Nombre,             
                Email = Email,
                Usuario = Usuario,
                Contracena = Contracena               
            };
            await servicio.AddUsuario(model);
            await Task.Delay(2000);
        }

        /*private async Task Modificar()
        {
            model = new RegisterModel()
            {
                Nombre = Nombre,
                Id = Id
            };
            //servicio.Modificar(model);
            await Task.Delay(2000);
        }

        private async Task Eliminar()
        {
            model = new RegisterModel()
            {
                Nombre = Nombre,
                Id = Id
            };
            //servicio.Eliminar(Id);
            await Task.Delay(2000);
        }

        private void Limpiar()
        {
            Nombre = "";
            //Apellido = "";
            //Edad = 0;
            Id = "";
        }*/

    }

}
