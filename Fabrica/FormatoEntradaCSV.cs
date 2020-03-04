using RastreoPaquetes.Estrategia;
using RastreoPaquetes.Estrategia.Interfaces;
using RastreoPaquetes.Fabrica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Fabrica
{
    class FormatoEntradaCSV : IFormatoEntradaFactory
    {
        public IProcesadorEntrada GenerarInstaciaFormatoEntrada()
        {
            return new ProcesarEntradaCSV();
        }
    }
}
