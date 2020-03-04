using RastreoPaquetes.Entidades;
using RastreoPaquetes.Estrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Estrategia
{
    class ProcesaMensaje : IProcesadorMensajes
    {
        public string ProcesarMensajes(Pedido pedido, ExpresionesMensajes expresionesMensajes, RangoTiempo rangoTiempo, decimal costoEnvio)
        {
            //Tu paquete [Expresión1] de [Origen] y [Expresión2] a [Destino] [Expresión3] [Rango de Tiempo] y [Expresión4] un costo de [Costo de envío] (Cualquier reclamación con [Paquetería]).

            string cMensaje =
                string.Format
                ("Tu paquete {0} de {1} y {2} a {3} {4} {5} y {6} un costo de {7} (Cualquier reclamación con {8}).",
                    expresionesMensajes.expresionMensajeUno,
                    pedido.cOrigen,
                    expresionesMensajes.expresionMensajeDos,
                    pedido.cDestino,
                    expresionesMensajes.expresionMensajeTres,
                    rangoTiempo.ToString(),
                    expresionesMensajes.expresionMensajeCuatro,
                    costoEnvio.ToString(),
                    pedido.cPaqueteria
                    );

            return cMensaje;


        }
    }
}
