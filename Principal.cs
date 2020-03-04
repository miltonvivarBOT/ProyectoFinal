using RastreoPaquetes.CadenaResponsabilidad;
using RastreoPaquetes.Entidades;
using RastreoPaquetes.Estrategia;
using RastreoPaquetes.Estrategia.Interfaces;
using RastreoPaquetes.Fabrica;
using RastreoPaquetes.Fabrica.Interfaces;
using RastreoPaquetes.Generales;
using RastreoPaquetes.Generales.Interfaces;
using RastreoPaquetes.Puente;
using RastreoPaquetes.Puente.Interfaces;
using RastreoPaquetes.Puente.MediosTransporte;
using RastreoPaquetes.Puente.ServiciosPaqueteria;
using System;
using System.Collections.Generic;

namespace RastreoPaquetes
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string RutaPedido = @"C:\Proyectos\ProyectoFinal_BPPD\RastreoPaquetes\Pedidos.csv";
            IObtenedorFechaActual obtenedorFecha = new FechaActual();
            IProcesadorExpresionesMensaje procesadorExpresiones = new ProcesardorExpresionMensajes(obtenedorFecha);
            IValidadorEstatusEntrega validadorEstatusEntrega = new EstatusEntrega(obtenedorFecha);

            IProcesadorMensajes procesadorMensajes =new ProcesaMensaje();
            IPresentadorMensaje presentadorMensaje = new ImprimirMensajeConsola();
            RangoBase rgBase = new RangoBase(obtenedorFecha);
            RangoMinutos minutos = new RangoMinutos(rgBase);
            RangoHoras horas = new RangoHoras(rgBase);
            RangoDias dia = new RangoDias(rgBase);
            RangoMeses mes = new RangoMeses(rgBase);
            minutos.SetSiguienteCalculo(horas);
            horas.SetSiguienteCalculo(dia);
            dia.SetSiguienteCalculo(mes);



            IFormatoEntradaFactory formatoFactory = new FormatoEntradaCSV();
            var formatoEntrada = formatoFactory.GenerarInstaciaFormatoEntrada();
            List<Pedido> lstPedidos = formatoEntrada.ObtenerEntradaPedidos(RutaPedido);
            IMediosTransporte mediosTransporte;
            
            mediosTransporte = new TransporteTren();
            mediosTransporte = new TransporteBarco();
            mediosTransporte = new TransporteAvion();


            IEmpresasPaqueteria empresasPaqueteria = 
                new PaqueteriaDHL(mediosTransporte, procesadorExpresiones, validadorEstatusEntrega, minutos, procesadorMensajes, presentadorMensaje);

            empresasPaqueteria.ProcesarRastreo(lstPedidos[0]);
            
        }
    }
}
