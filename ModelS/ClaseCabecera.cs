using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class ClaseCabecera
    {
        public ClaseCabecera()
        {
            ClaseDetalle = new HashSet<ClaseDetalle>();
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public int? PlanEstudioDetalleId { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? IsActive { get; set; }

        public PlanEstudioDetalle PlanEstudioDetalle { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<ClaseDetalle> ClaseDetalle { get; set; }
    }
}
