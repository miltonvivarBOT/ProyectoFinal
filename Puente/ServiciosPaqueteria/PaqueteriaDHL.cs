using RastreoPaquetes.CadenaResponsabilidad.Interfaces;
using RastreoPaquetes.Entidades;
using RastreoPaquetes.Estrategia.Interfaces;
using RastreoPaquetes.Generales.Interfaces;
using RastreoPaquetes.Puente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Puente.ServiciosPaqueteria
{
    class PaqueteriaDHL : IEmpresasPaqueteria
    {
        public int porcentajeUtilidad
        {
            get { return 40; }
        }

        private readonly IMediosTransporte mediosTransporte;
        private readonly IProcesadorExpresionesMensaje procesadorExpresionesMensaje;
        private readonly IValidadorEstatusEntrega estatusEntrega;
        private readonly IProcesadorRangoFechas procesadorRangoFechas;
        private readonly IProcesadorMensajes procesadorMensajes;
        private readonly IPresentadorMensaje presentadorMensaje;

        public PaqueteriaDHL(IMediosTransporte mediosTransporte, 
                            IProcesadorExpresionesMensaje procesadorExpresionesMensaje, 
                            IValidadorEstatusEntrega estatusEntrega, 
                            IProcesadorRangoFechas procesadorRangoFechas,
                            IProcesadorMensajes procesadorMensajes,
                            IPresentadorMensaje presentadorMensaje)
        {
            this.mediosTransporte = mediosTransporte;
            this.procesadorExpresionesMensaje = procesadorExpresionesMensaje;
            this.estatusEntrega = estatusEntrega;
            this.procesadorRangoFechas = procesadorRangoFechas;
            this.procesadorMensajes = procesadorMensajes;
            this.presentadorMensaje = presentadorMensaje;
        }
       
        public void ProcesarRastreo(Pedido pedido)
        {
            var tiempotraslado = mediosTransporte.ObtenerTiempoTraslado(pedido.dDistancia);
            var fechaEntrega = mediosTransporte.ObtenerFechaEntrega(pedido.dtFechaPedido, tiempotraslado);
            var costoEnvio = mediosTransporte.CalcularCostoEnvio(pedido.dDistancia, this.porcentajeUtilidad);
            ExpresionesMensajes expMensaje = procesadorExpresionesMensaje.ObtenerExpresionesMensaje(fechaEntrega);
            bool lEstatusEntrega = estatusEntrega.ObtenerEstatusEntrega(fechaEntrega);
            var rangoTiempo = procesadorRangoFechas.CalcularRangoTiempo(fechaEntrega);

            var mensaje = procesadorMensajes.ProcesarMensajes(pedido, expMensaje, rangoTiempo, costoEnvio);
            presentadorMensaje.PresentaMensaje(mensaje, lEstatusEntrega);

        }
    }
}
