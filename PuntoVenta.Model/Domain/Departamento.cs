﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class Departamento
    {
        int id;
        String nombre;
        int cantidadEmpleados;
        Compania compania;

        public Departamento()
        {
            compania = new Compania();
        }

        public Departamento(int id, string nombre, int cantidadEmpleados, Compania compania)
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidadEmpleados = cantidadEmpleados;
            this.compania = compania;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CantidadEmpleados { get => cantidadEmpleados; set => cantidadEmpleados = value; }
        public Compania Compania { get => compania; set => compania = value; }
    }
}
