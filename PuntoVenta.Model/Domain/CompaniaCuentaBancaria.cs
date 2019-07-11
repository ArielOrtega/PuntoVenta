using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class CompaniaCuentaBancaria
    {
        int id;
        int numeroCuenta;
        String tipoCuenta;
        String tipoDivisa;
        bool estado;
        String pais;
        String provincia;
        Banco banco;
        Compania compania;
        String nombreDueno;
        String apellidosDueno;

        public CompaniaCuentaBancaria()
        {
            banco = new Banco();
            compania = new Compania();
        }

        public CompaniaCuentaBancaria(int id, int numeroCuenta, string tipoCuenta, string tipoDivisa, bool estado, string pais, string provincia, Banco banco, Compania compania, string nombreDueno, string apellidosDueno)
        {
            this.id = id;
            this.numeroCuenta = numeroCuenta;
            this.tipoCuenta = tipoCuenta;
            this.tipoDivisa = tipoDivisa;
            this.estado = estado;
            this.pais = pais;
            this.provincia = provincia;
            this.banco = banco;
            this.compania = compania;
            this.nombreDueno = nombreDueno;
            this.apellidosDueno = apellidosDueno;
        }

        public int Id { get => id; set => id = value; }
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public string TipoDivisa { get => tipoDivisa; set => tipoDivisa = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public Banco Banco { get => banco; set => banco = value; }
        public Compania Compania { get => compania; set => compania = value; }
        public string NombreDueno { get => nombreDueno; set => nombreDueno = value; }
        public string ApellidosDueno { get => apellidosDueno; set => apellidosDueno = value; }
    }
}
