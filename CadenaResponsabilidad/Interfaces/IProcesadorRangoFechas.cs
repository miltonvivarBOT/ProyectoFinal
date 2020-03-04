using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad.Interfaces
{
    interface IProcesadorRangoFechas
    {
        RangoTiempo CalcularRangoTiempo(DateTime fechaEntrega);
        void SetSiguienteCalculo(IProcesadorRangoFechas procesadorRangoFechas);
    }
}
