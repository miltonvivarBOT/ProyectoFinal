using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad.Interfaces
{
    interface ICalculadorRangoBase
    {
        TimeSpan CalcularRangoBase(DateTime fechaEvento);
    }
}
