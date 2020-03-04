using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Estrategia.Interfaces
{
    interface IPresentadorMensaje
    {
        void PresentaMensaje(string mensaje, bool lEntregado);
    }
}
