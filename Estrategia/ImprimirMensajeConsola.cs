using RastreoPaquetes.Estrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Estrategia
{
    class ImprimirMensajeConsola : IPresentadorMensaje
    {
        public void PresentaMensaje(string mensaje, bool lEntregado)
        {
            Console.WriteLine(mensaje);
        }
    }
}
