using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Estrategia.Interfaces
{
    interface IProcesadorMensajes
    {
        string ProcesarMensajes(Pedido pedido, ExpresionesMensajes expresionesMensajes, RangoTiempo rangoTiempo, decimal costoEnvio);
    }
}
