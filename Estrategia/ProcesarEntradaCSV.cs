using RastreoPaquetes.Entidades;
using RastreoPaquetes.Estrategia.Interfaces;
using RastreoPaquetes.Generales;
using RastreoPaquetes.Generales.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Estrategia
{
    class ProcesarEntradaCSV : IProcesadorEntrada
    {
        public List<Pedido> ObtenerEntradaPedidos(string rutaPedidos)
        {
            List<Pedido> lstPedidos = new List<Pedido>();
            ISeparadorLineas separadorLineas = new SepararComas();

            string[] LineasArchivo = System.IO.File.ReadAllLines(rutaPedidos);
            lstPedidos = ProcesarArchivo(separadorLineas, LineasArchivo);
            return lstPedidos;
        }
        private List<Pedido> ProcesarArchivo(ISeparadorLineas separadorLineas, string[] LineasArchivo)
        {
            string[] DatoArchivo;
            List<Pedido> lstPedidos = new List<Pedido>();
            foreach (string linea in LineasArchivo)
            {
                DatoArchivo = separadorLineas.SepararLinea(linea);
                lstPedidos.Add(CrearObjetoPedido(DatoArchivo));
            }
            return lstPedidos;
        }
        private Pedido CrearObjetoPedido(string[] DatoArchivo)
        {
            return new Pedido(
                DatoArchivo[0],
                DatoArchivo[1],
                Convert.ToDecimal(DatoArchivo[2]),
                DatoArchivo[3],
                DatoArchivo[4],
                Convert.ToDateTime(DatoArchivo[5]));
        }
    }
}
