using RastreoPaquetes.Estrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Fabrica.Interfaces
{
    interface IFormatoEntradaFactory
    {
        IProcesadorEntrada GenerarInstaciaFormatoEntrada();
    }
}
