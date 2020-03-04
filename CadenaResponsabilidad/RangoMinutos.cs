using RastreoPaquetes.CadenaResponsabilidad.Interfaces;
using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad
{
    class RangoMinutos : IProcesadorRangoFechas
    {
        private readonly ICalculadorRangoBase calculadorRangoBase;
        private IProcesadorRangoFechas _rangoSiguienteCalculo;

        #region Constructor
        public RangoMinutos(ICalculadorRangoBase calculadorRangoBase)
        {
            this.calculadorRangoBase = calculadorRangoBase;
        }
        #endregion

        #region [Miembros de IProcesadorRangoFechas]
        public RangoTiempo CalcularRangoTiempo(DateTime fechaEvento)
        {
            int Minutos = 0;
            TimeSpan rangoBase = calculadorRangoBase.CalcularRangoBase(fechaEvento);
            Minutos = ObtenerDiferenciaMinutos(rangoBase);
            if (Minutos < 60)
            {
                RangoTiempo rangoTiempo = this.GenerarObjetoRangoTiempo(Minutos);
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
        private RangoTiempo GenerarObjetoRangoTiempo(int minutos)
        {
            RangoTiempo rangotiempo = new RangoTiempo(minutos, "minutos");
            return rangotiempo;
        }
        private int ObtenerDiferenciaMinutos(TimeSpan rangoBase)
        {
            int Minutos = 0;
            Minutos = Math.Abs(Convert.ToInt32(rangoBase.TotalMinutes));
            return Minutos;
        }
        #endregion
    }
}
