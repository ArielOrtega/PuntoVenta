using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class PosOrdenDetalle
    {
        PosOrden posOrden;
        Producto producto;
        float impuesto;
        int cantidad;
        float descuento;
        float precioUnitario;
        float precioSubtotal;

        public PosOrdenDetalle()
        {
            posOrden = new PosOrden();
            producto = new Producto();
        }

        public PosOrdenDetalle(PosOrden posOrden, Producto producto, float impuesto, int cantidad, float descuento, float precioUnitario, float precioSubtotal)
        {
            this.posOrden = posOrden;
            this.producto = producto;
            this.impuesto = impuesto;
            this.cantidad = cantidad;
            this.descuento = descuento;
            this.precioUnitario = precioUnitario;
            this.precioSubtotal = precioSubtotal;
        }

        public PosOrden PosOrden { get => posOrden; set => posOrden = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public float Impuesto { get => impuesto; set => impuesto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public float PrecioSubtotal { get => precioSubtotal; set => precioSubtotal = value; }
    }
}
