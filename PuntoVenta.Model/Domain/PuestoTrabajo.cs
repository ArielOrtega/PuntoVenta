using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class PuestoTrabajo
    {
        int id;
        String nombre;
        float salarioMensual;
        Compania compania;

        public PuestoTrabajo()
        {
            compania = new Compania();
        }

        public PuestoTrabajo(int id, string nombre, float salarioMensual, Compania compania)
        {
            this.id = id;
            this.nombre = nombre;
            this.salarioMensual = salarioMensual;
            this.compania = compania;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float SalarioMensual { get => salarioMensual; set => salarioMensual = value; }
        public Compania Compania { get => compania; set => compania = value; }
    }
}
