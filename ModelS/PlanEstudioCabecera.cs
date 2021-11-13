using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class PlanEstudioCabecera
    {
        public PlanEstudioCabecera()
        {
            PlanEstudioDetalle = new HashSet<PlanEstudioDetalle>();
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? IsActive { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<PlanEstudioDetalle> PlanEstudioDetalle { get; set; }
    }
}
