using RastreoPaquetes.CadenaResponsabilidad.Interfaces;
using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad
{
    class RangoDias : IProcesadorRangoFechas
    {
        private readonly ICalculadorRangoBase calculadorRangoBase;
        private IProcesadorRangoFechas _rangoSiguienteCalculo;

        #region Constructor
        public RangoDias(ICalculadorRangoBase calculadorRangoBase)
        {
            this.calculadorRangoBase = calculadorRangoBase;
        }
        #endregion

        #region [Miembros de IProcesadorRangoFechas]
        public RangoTiempo CalcularRangoTiempo(DateTime fechaEvento)
        {
            int Dias = 0;
            TimeSpan rangoBase = calculadorRangoBase.CalcularRangoBase(fechaEvento);
            Dias = ObtenerDiferenciaDias(rangoBase);
            if (Dias < 31)
            {
                RangoTiempo rangoTiempo = this.GenerarObjetoRangoTiempo(Dias);
                return rangoTiempo;
            }
            else
            {
                return _rangoSiguienteCalculo.CalcularRangoTiempo(fechaEvento);
            }
        }
        public void SetSiguienteCalculo(IProcesadorRangoFechas rangoFechas)
        {
            _rangoSiguienteCalculo = rangoFechas;
        }
        #endregion

        #region [Privados]
        private RangoTiempo GenerarObjetoRangoTiempo(int dias)
        {
            RangoTiempo rangotiempo = new RangoTiempo(dias, "dias");
            return rangotiempo;
        }
        private int ObtenerDiferenciaDias(TimeSpan rangoBase)
        {
            int Dias = 0;
            Dias = Math.Abs(Convert.ToInt32(rangoBase.TotalHours));
            return Dias;
        }
        #endregion
    }
}
