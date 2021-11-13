using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Curso
    {
        public Curso()
        {
            PlanEstudioDetalle = new HashSet<PlanEstudioDetalle>();
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int? NivelId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaModficacion { get; set; }
        public bool? EsActivo { get; set; }

        public Curso IdNavigation { get; set; }
        public Nivel Nivel { get; set; }
        public Usuario Usuario { get; set; }
        public Curso InverseIdNavigation { get; set; }
        public ICollection<PlanEstudioDetalle> PlanEstudioDetalle { get; set; }
    }
}
