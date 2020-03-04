using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Puente.Interfaces
{
    interface IMediosTransporte
    {
        decimal costoKm { get; }
        decimal velocidad { get; }
        decimal ObtenerTiempoTraslado(decimal distancia);
        DateTime ObtenerFechaEntrega(DateTime fechaPedido, decimal tiempoTraslado);
        decimal CalcularCostoEnvio(decimal distancia, int porcentajeUtilidad);
    }
}
