using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class Producto
    {
        int productId;
        String nombreEtiqueta;
        String descripcion;
        int existenciaEnStock;
        int existenciaLimiteAlerta;
        float precioNeto;
        float precioMinimo;
        float precioMinimoImpuesto;
        String fechaCreacion;
        bool puedeVenderse;
        bool puedeComprarse;
        float impuestoValorAgregado;
        float impuestoLocal1;
        float impuestoLocal2;
        bool tieneImpuesto;
        bool codigoBarra;
        String imagen;
        int codigoContableVentas;
        int codigoContableCompras;
        float peso;
        float unidadPeso;
        float longitud;
        float unidadLongitud;
        float superficie;
        float unidadSuperficie;
        float volumen;

        public Producto()
        {

        }

        public Producto(int productId, string nombreEtiqueta, string descripcion, int existenciaEnStock, int existenciaLimiteAlerta, float precioNeto, float precioMinimo, float precioMinimoImpuesto, string fechaCreacion, bool puedeVenderse, bool puedeComprarse, float impuestoValorAgregado, float impuestoLocal1, float impuestoLocal2, bool tieneImpuesto, bool codigoBarra, string imagen, int codigoContableVentas, int codigoContableCompras, float peso, float unidadPeso, float longitud, float unidadLongitud, float superficie, float unidadSuperficie, float volumen)
        {
            this.productId = productId;
            this.nombreEtiqueta = nombreEtiqueta;
            this.descripcion = descripcion;
            this.existenciaEnStock = existenciaEnStock;
            this.existenciaLimiteAlerta = existenciaLimiteAlerta;
            this.precioNeto = precioNeto;
            this.precioMinimo = precioMinimo;
            this.precioMinimoImpuesto = precioMinimoImpuesto;
            this.fechaCreacion = fechaCreacion;
            this.puedeVenderse = puedeVenderse;
            this.puedeComprarse = puedeComprarse;
            this.impuestoValorAgregado = impuestoValorAgregado;
            this.impuestoLocal1 = impuestoLocal1;
            this.impuestoLocal2 = impuestoLocal2;
            this.tieneImpuesto = tieneImpuesto;
            this.codigoBarra = codigoBarra;
            this.imagen = imagen;
            this.codigoContableVentas = codigoContableVentas;
            this.codigoContableCompras = codigoContableCompras;
            this.peso = peso;
            this.unidadPeso = unidadPeso;
            this.longitud = longitud;
            this.unidadLongitud = unidadLongitud;
            this.superficie = superficie;
            this.unidadSuperficie = unidadSuperficie;
            this.volumen = volumen;
        }

        public int ProductId { get => productId; set => productId = value; }
        public string NombreEtiqueta { get => nombreEtiqueta; set => nombreEtiqueta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int ExistenciaEnStock { get => existenciaEnStock; set => existenciaEnStock = value; }
        public int ExistenciaLimiteAlerta { get => existenciaLimiteAlerta; set => existenciaLimiteAlerta = value; }
        public float PrecioNeto { get => precioNeto; set => precioNeto = value; }
        public float PrecioMinimo { get => precioMinimo; set => precioMinimo = value; }
        public float PrecioMinimoImpuesto { get => precioMinimoImpuesto; set => precioMinimoImpuesto = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public bool PuedeVenderse { get => puedeVenderse; set => puedeVenderse = value; }
        public bool PuedeComprarse { get => puedeComprarse; set => puedeComprarse = value; }
        public float ImpuestoValorAgregado { get => impuestoValorAgregado; set => impuestoValorAgregado = value; }
        public float ImpuestoLocal1 { get => impuestoLocal1; set => impuestoLocal1 = value; }
        public float ImpuestoLocal2 { get => impuestoLocal2; set => impuestoLocal2 = value; }
        public bool TieneImpuesto { get => tieneImpuesto; set => tieneImpuesto = value; }
        public bool CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int CodigoContableVentas { get => codigoContableVentas; set => codigoContableVentas = value; }
        public int CodigoContableCompras { get => codigoContableCompras; set => codigoContableCompras = value; }
        public float Peso { get => peso; set => peso = value; }
        public float UnidadPeso { get => unidadPeso; set => unidadPeso = value; }
        public float Longitud { get => longitud; set => longitud = value; }
        public float UnidadLongitud { get => unidadLongitud; set => unidadLongitud = value; }
        public float Superficie { get => superficie; set => superficie = value; }
        public float UnidadSuperficie { get => unidadSuperficie; set => unidadSuperficie = value; }
        public float Volumen { get => volumen; set => volumen = value; }
    }
}
