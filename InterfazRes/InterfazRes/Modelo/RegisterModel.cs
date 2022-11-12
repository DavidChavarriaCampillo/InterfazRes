using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InterfazRes.Modelo
{
    public class RegisterModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        private string documento;
        public string Documento
        {
            get { return documento; }
            set
            {
                documento = value;
                OnPropertyChanged();
            }
        }

        private string contracena;
        public string Contracena
        {
            get { return contracena; }
            set
            {
                contracena = value;
                OnPropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                OnPropertyChanged();
            }
        }

        /*public string Mensaje
        {
            get
            {
                return $"Tu nombre es: ";
            }
        }*/

        /*public bool IsBusy
        {
            get { return IsBusy; }
            set { IsBusy = value; }
        }*/
    }
}
