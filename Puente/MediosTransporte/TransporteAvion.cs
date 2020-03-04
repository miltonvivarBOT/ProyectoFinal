using RastreoPaquetes.Puente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Puente.MediosTransporte
{
    class TransporteAvion : IMediosTransporte
    {
        public decimal costoKm
        {
            get { return 10.00M; }
        }
        public decimal velocidad
        {
            get { return 600.00M; }
        }

        public decimal CalcularCostoEnvio(decimal distancia, int porcentajeUtilidad)
        {
            return costoKm * distancia * (1 + (porcentajeUtilidad / 100));
        }

        public DateTime ObtenerFechaEntrega(DateTime fechaPedido, decimal tiempoTraslado)
        {
            return fechaPedido.AddHours(Convert.ToDouble(tiempoTraslado));
        }

        public decimal ObtenerTiempoTraslado(decimal distancia)
        {
            return distancia / velocidad;
        }
    }
}
