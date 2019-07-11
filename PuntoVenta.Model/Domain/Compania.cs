using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class Compania
    {
        int id;
        String nombre;
        String logo;
        String email;
        String telefono;
        String cedulaJuridica;
        String pais;
        String direccion;


        public Compania()
        {

        }

        public Compania(int id, string nombre, string logo, string email, string telefono, string cedulaJuridica, string pais, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.logo = logo;
            this.email = email;
            this.telefono = telefono;
            this.cedulaJuridica = cedulaJuridica;
            this.pais = pais;
            this.direccion = direccion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Logo { get => logo; set => logo = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CedulaJuridica { get => cedulaJuridica; set => cedulaJuridica = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
