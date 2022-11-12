using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterfazRes.viewModel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }
        public List<Pick> MenuList { get; set; }
        //public ICommand BackCommand => new Command(() => ApplicationException.Current.MainPage.Navigation.PopAsync());

        public List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick{Title="Squirtle", Image="producto1.png", Description="Un masajeador clitoriano de diseño minimalista y compacto.", Price="80$"},
                new Pick{Title="Butt Plug", Image="producto2.png", Description="Acostumbrador Con Joya Colores", Price="30$"},
                new Pick{Title="Druida", Image="producto3.png", Description="Masajeador con un elegante diseño adaptado al cuerpo femenino que contiene dos discretos y potentes motores.", Price="70$"}
            };
        }
    }
}
