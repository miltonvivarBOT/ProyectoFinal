using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Puente.Interfaces
{
    interface IEmpresasPaqueteria
    {
        int porcentajeUtilidad { get; }
        void ProcesarRastreo(Pedido pedido);
        
    }
}
