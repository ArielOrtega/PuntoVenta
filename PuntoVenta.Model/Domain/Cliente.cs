using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class Cliente
    {
        int id;
        String apellidos;
        String nombre;
        int numeroIdentificacion;
        String loginName;
        String password;
        String direccion;
        String ciudad;
        String nacionalidad;
        String telefono;
        String email;
        String photo;
        bool activo;

        public Cliente()
        {

        }

        public Cliente(int id, string apellidos, string nombre, int numeroIdentificacion, string loginName, string password, string direccion, string ciudad, string nacionalidad, string telefono, string email, string photo, bool activo)
        {
            this.id = id;
            this.apellidos = apellidos;
            this.nombre = nombre;
            this.numeroIdentificacion = numeroIdentificacion;
            this.loginName = loginName;
            this.password = password;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.nacionalidad = nacionalidad;
            this.telefono = telefono;
            this.email = email;
            this.photo = photo;
            this.activo = activo;
        }

        public int Id { get => id; set => id = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Photo { get => photo; set => photo = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
