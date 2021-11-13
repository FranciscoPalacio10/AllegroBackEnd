using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class Estilo
    {
        public Estilo()
        {
            PlanEstudioDetalle = new HashSet<PlanEstudioDetalle>();
        }

        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string HashFoto { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaModficacion { get; set; }
        public bool? IsActive { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<PlanEstudioDetalle> PlanEstudioDetalle { get; set; }
    }
}
