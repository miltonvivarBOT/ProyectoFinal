using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Entidades
{
    class RangoTiempo
    {
        public RangoTiempo(int tiempo, string periodo)
        {
            iTiempo = tiempo;
            cPeriodo = periodo;

        }
        public int iTiempo { get; set; }
        public string cPeriodo { get; set; }
    }
}
