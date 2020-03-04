using RastreoPaquetes.CadenaResponsabilidad.Interfaces;
using RastreoPaquetes.Entidades;
using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad
{
    class RangoMeses : IProcesadorRangoFechas
    {
        private readonly ICalculadorRangoBase calculadorRangoBase;
        private IProcesadorRangoFechas _rangoSiguienteCalculo;

        #region [Constructor]
        public RangoMeses(ICalculadorRangoBase rangoBase)
        {
            calculadorRangoBase = rangoBase;
        }
        #endregion
        
        #region[Miembros de ICalculadorRangoEvento]
        public RangoTiempo CalcularRangoTiempo(DateTime fechaEvento)
        {
            return GenerarObjetoRangoTiempo(0);
        }
        public void SetSiguienteCalculo(IProcesadorRangoFechas rangoFechas)
        {
            _rangoSiguienteCalculo = rangoFechas;
        }
        #endregion

        #region [Privados]
        private RangoTiempo GenerarObjetoRangoTiempo(int Meses)
        {
            RangoTiempo rangotiempo = new RangoTiempo(Meses, "sin limite");
            return rangotiempo;
        }
        #endregion


    }
}
