using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Generales
{
    class SepararComas : ISeparadorLineas
    {
        public string[] SepararLinea(string linea)
        {
            string[] DatosLinea;
            DatosLinea = linea.Split(',');
            return DatosLinea;
        }
    }
}
