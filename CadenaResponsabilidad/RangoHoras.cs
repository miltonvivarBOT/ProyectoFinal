using RastreoPaquetes.CadenaResponsabilidad.Interfaces;
using RastreoPaquetes.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.CadenaResponsabilidad
{
    class RangoHoras : IProcesadorRangoFechas
    {
        private readonly ICalculadorRangoBase calculadorRangoBase;
        private IProcesadorRangoFechas _rangoSiguienteCalculo;

        #region Constructor
        public RangoHoras(ICalculadorRangoBase calculadorRangoBase)
        {
            this.calculadorRangoBase = calculadorRangoBase;
        }
        #endregion

        #region [Miembros de IProcesadorRangoFechas]
        public RangoTiempo CalcularRangoTiempo(DateTime fechaEvento)
        {
            int Horas = 0;
            TimeSpan rangoBase = calculadorRangoBase.CalcularRangoBase(fechaEvento);
            Horas = ObtenerDiferenciaHoras(rangoBase);
            if (Horas < 24)
            {
                RangoTiempo rangoTiempo = this.GenerarObjetoRangoTiempo(Horas);
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
        private RangoTiempo GenerarObjetoRangoTiempo(int horas)
        {
            RangoTiempo rangotiempo = new RangoTiempo(horas, "horas");
            return rangotiempo;
        }
        private int ObtenerDiferenciaHoras(TimeSpan rangoBase)
        {
            int Horas = 0;
            Horas = Math.Abs(Convert.ToInt32(rangoBase.TotalHours));
            return Horas;
        }
        #endregion
    }
}
