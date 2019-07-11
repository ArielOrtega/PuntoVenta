using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class Empleado
    {
        int id;
        String apellidos;
        String nombre;
        int numeroIdenficacion;
        String loginName;
        String password;
        String estadoCivil;
        String direccion;
        String ciudad;
        String nacionalidad;
        String telefono;
        String email;
        Compania compania;
        Departamento departamento;
        PuestoTrabajo puestoTrabajo;
        String photo;
        bool activo;
        int numeroCuentaBancaria;
        String nombreBancoCuenta;
        List<GruposAcceso> gruposAcceso;

        public Empleado()
        {
            compania = new Compania();
            departamento = new Departamento();
            puestoTrabajo = new PuestoTrabajo();
            gruposAcceso = new List<GruposAcceso>();
        }

        public Empleado(int id, string apellidos, string nombre, int numeroIdenficacion, string loginName, string password, string estadoCivil, string direccion, string ciudad, string nacionalidad, string telefono, string email, Compania compania, Departamento departamento, PuestoTrabajo puestoTrabajo, string photo, bool activo, int numeroCuentaBancaria, string nombreBancoCuenta, List<GruposAcceso> gruposAcceso)
        {
            this.id = id;
            this.apellidos = apellidos;
            this.nombre = nombre;
            this.numeroIdenficacion = numeroIdenficacion;
            this.loginName = loginName;
            this.password = password;
            this.estadoCivil = estadoCivil;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.nacionalidad = nacionalidad;
            this.telefono = telefono;
            this.email = email;
            this.compania = compania;
            this.departamento = departamento;
            this.puestoTrabajo = puestoTrabajo;
            this.photo = photo;
            this.activo = activo;
            this.numeroCuentaBancaria = numeroCuentaBancaria;
            this.nombreBancoCuenta = nombreBancoCuenta;
            this.gruposAcceso = gruposAcceso;
        }

        public int Id { get => id; set => id = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroIdenficacion { get => numeroIdenficacion; set => numeroIdenficacion = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public Compania Compania { get => compania; set => compania = value; }
        public Departamento Departamento { get => departamento; set => departamento = value; }
        public PuestoTrabajo PuestoTrabajo { get => puestoTrabajo; set => puestoTrabajo = value; }
        public string Photo { get => photo; set => photo = value; }
        public bool Activo { get => activo; set => activo = value; }
        public int NumeroCuentaBancaria { get => numeroCuentaBancaria; set => numeroCuentaBancaria = value; }
        public string NombreBancoCuenta { get => nombreBancoCuenta; set => nombreBancoCuenta = value; }
        public List<GruposAcceso> GruposAcceso { get => gruposAcceso; set => gruposAcceso = value; }
    }
}
