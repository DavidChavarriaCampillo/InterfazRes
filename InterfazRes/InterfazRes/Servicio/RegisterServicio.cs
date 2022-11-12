using Firebase.Database;
using Firebase.Database.Query;
using InterfazRes.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace InterfazRes.Servicio
{
    internal class RegisterServicio
    {
        FirebaseClient firebase;

        public RegisterServicio()
        {
            firebase = new FirebaseClient("https://sexshopxdb-default-rtdb.firebaseio.com/");
        }

        public async Task<List<RegisterModel>> GetUsuarios()
        {
            return (await firebase.Child("Usuarios").OnceAsync<RegisterModel>()).Select(item => new RegisterModel
            {
                Id = item.Object.Id,
                Documento = item.Object.Documento,
                Nombre = item.Object.Nombre,
                Email = item.Object.Email,
                Usuario = item.Object.Usuario,
                Contracena = item.Object.Contracena
            }).ToList();
        }

        public async Task AddUsuario(RegisterModel usuario)
        {
            await firebase.Child("Usuarios").PostAsync(usuario);
        }
    }
}
