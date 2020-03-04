using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Generales.Interfaces
{
    interface IValidadorEstatusEntrega
    {
        bool ObtenerEstatusEntrega(DateTime fechaEntrega);
    }
}
