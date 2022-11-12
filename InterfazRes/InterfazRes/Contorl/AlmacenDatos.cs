using InterfazRes.viewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazRes.Contorl
{
    internal class AlmacenDatos
    {

        List<RegisterViewModel> usuarios = new List<RegisterViewModel>();

        public void Almacen(RegisterViewModel objeto)
        {

            usuarios.Add(objeto);


        }

    }
}
