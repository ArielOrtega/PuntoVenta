using System;
using System.Collections.Generic;
using System.Text;

namespace PuntoVenta.Model.Domain
{
    public class GruposAcceso
    {
        int id;
        String nombreGrupo;
        String comentario;

        public GruposAcceso()
        {
        }

        public GruposAcceso(int id, string nombreGrupo, string comentario)
        {
            this.id = id;
            this.nombreGrupo = nombreGrupo;
            this.comentario = comentario;
        }

        public int Id { get => id; set => id = value; }
        public string NombreGrupo { get => nombreGrupo; set => nombreGrupo = value; }
        public string Comentario { get => comentario; set => comentario = value; }
    }
}
