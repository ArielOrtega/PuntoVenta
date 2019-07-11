using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class Banco
    {
        int id;
        int codigoIdentificadorBanco;
        String nombre;
        String email;
        String ciudad;
        String fax;
        int zip;
        String pais;
        String direccion;
        String telefono;
        String estadoPais;
        bool activo;

        public Banco()
        {
        }

        public Banco(int id, int codigoIdentificadorBanco, string nombre, string email, string ciudad, string fax, int zip, string pais, string direccion, string telefono, string estadoPais, bool activo)
        {
            this.id = id;
            this.codigoIdentificadorBanco = codigoIdentificadorBanco;
            this.nombre = nombre;
            this.email = email;
            this.ciudad = ciudad;
            this.fax = fax;
            this.zip = zip;
            this.pais = pais;
            this.direccion = direccion;
            this.telefono = telefono;
            this.estadoPais = estadoPais;
            this.activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public int CodigoIdentificadorBanco { get => codigoIdentificadorBanco; set => codigoIdentificadorBanco = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Fax { get => fax; set => fax = value; }
        public int Zip { get => zip; set => zip = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string EstadoPais { get => estadoPais; set => estadoPais = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
