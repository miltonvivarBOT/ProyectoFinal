using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Generales
{
    class FechaActual : IObtenedorFechaActual
    {
        public DateTime ObtenerFechaActual { get { return DateTime.Now; } }
    }
}
