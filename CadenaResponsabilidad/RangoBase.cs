using RastreoPaquetes.CadenaResponsabilidad.Interfaces;
using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad
{
    class RangoBase : ICalculadorRangoBase
    {
        private readonly IObtenedorFechaActual obtenedorFecha;

        public RangoBase(IObtenedorFechaActual obtenedorFecha)
        {
            this.obtenedorFecha = obtenedorFecha;
        }


        #region [Miembros de ICalculadorRangoBase]
        public TimeSpan CalcularRangoBase(DateTime fechaEntrega)
        {
            DateTime fechaHoy = obtenedorFecha.ObtenerFechaActual;
            TimeSpan rangoBase = fechaHoy.Subtract(fechaEntrega);
            return rangoBase;
        }
        #endregion
    }
}
