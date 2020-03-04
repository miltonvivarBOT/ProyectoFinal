using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Generales
{
    class EstatusEntrega : IValidadorEstatusEntrega
    {
        private readonly IObtenedorFechaActual obtenedorFecha;

        public EstatusEntrega(IObtenedorFechaActual obtenedorFecha)
        {
            this.obtenedorFecha = obtenedorFecha;
        }
        public bool ObtenerEstatusEntrega(DateTime fechaEntrega)
        {
            if (fechaEntrega < obtenedorFecha.ObtenerFechaActual)
                return true;
            else
                return false;
        }
    }
}
