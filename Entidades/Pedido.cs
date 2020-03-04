using System;
using System.Collections.Generic;
using System.Text;

namespace RastreoPaquetes.Entidades
{
    class Pedido
    {
        public Pedido(string Origen, string Destino, decimal Distancia, string Paqueteria, string MedioTransporte, DateTime FechaPedido )
        {
            this.cOrigen = Origen;
            this.cDestino = Destino;
            this.dDistancia = Distancia;
            this.cPaqueteria = Paqueteria;
            this.cMedioTransporte = MedioTransporte;
            this.dtFechaPedido = FechaPedido;
        }
        public string cOrigen { get; set; }
        public string cDestino { get; set; }
        public decimal dDistancia { get; set; }
        public string cPaqueteria { get; set; }
        public string cMedioTransporte { get; set; }
        public DateTime dtFechaPedido { get; set; }
    }
}
