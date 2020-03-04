using RastreoPaquetes.Entidades;
using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Generales
{
    class ProcesardorExpresionMensajes : IProcesadorExpresionesMensaje
    {
        private ExpresionesMensajes expresionesMensajes;
        private readonly IObtenedorFechaActual obtenedorFecha;
        public ProcesardorExpresionMensajes(IObtenedorFechaActual obtenedorFecha)
        {
            this.obtenedorFecha = obtenedorFecha;
        }
        public ExpresionesMensajes ObtenerExpresionesMensaje(DateTime fechaEntrega)
        {
            if (fechaEntrega < obtenedorFecha.ObtenerFechaActual)
                AsignarExpresionesFechaAnterior();
            else
                AsignarExpresionesFechaPosterior();
            return expresionesMensajes;
        }
        private void AsignarExpresionesFechaAnterior()
        {
            expresionesMensajes = new ExpresionesMensajes();
            expresionesMensajes.expresionMensajeUno = "salió";
            expresionesMensajes.expresionMensajeDos = "llegó";
            expresionesMensajes.expresionMensajeTres = "hace";
            expresionesMensajes.expresionMensajeCuatro = "tuvó";
        }
        private void AsignarExpresionesFechaPosterior()
        {
            expresionesMensajes = new ExpresionesMensajes();
            expresionesMensajes.expresionMensajeUno = "ha salido";
            expresionesMensajes.expresionMensajeDos = "llegará";
            expresionesMensajes.expresionMensajeTres = "dentro de";
            expresionesMensajes.expresionMensajeCuatro = "tendrá";
        }
    }
}
