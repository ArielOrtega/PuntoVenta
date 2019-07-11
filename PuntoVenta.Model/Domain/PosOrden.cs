using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class PosOrden
    {
        int numeroOrden;
        Cliente cliente;
        String fechaOrden;
        Empleado empleado;
        float totalOrden;
        float impuesto;

        public PosOrden()
        {
            cliente = new Cliente();
            empleado = new Empleado();
        }

        public PosOrden(int numeroOrden, Cliente cliente, string fechaOrden, Empleado empleado, float totalOrden, float impuesto)
        {
            this.numeroOrden = numeroOrden;
            this.cliente = cliente;
            this.fechaOrden = fechaOrden;
            this.empleado = empleado;
            this.totalOrden = totalOrden;
            this.impuesto = impuesto;
        }

        public int NumeroOrden { get => numeroOrden; set => numeroOrden = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        public float TotalOrden { get => totalOrden; set => totalOrden = value; }
        public float Impuesto { get => impuesto; set => impuesto = value; }
    }
}
