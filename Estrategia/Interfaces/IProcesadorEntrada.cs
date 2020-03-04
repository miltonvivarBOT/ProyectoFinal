using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Estrategia.Interfaces
{
    interface IProcesadorEntrada
    {
        List<Pedido> ObtenerEntradaPedidos(string rutaPedidos);
    }
}
