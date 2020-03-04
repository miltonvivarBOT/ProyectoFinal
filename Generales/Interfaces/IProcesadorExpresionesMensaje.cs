using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Generales.Interfaces
{
    interface IProcesadorExpresionesMensaje
    {
        ExpresionesMensajes ObtenerExpresionesMensaje(DateTime fechaEntrega);
    }
}
