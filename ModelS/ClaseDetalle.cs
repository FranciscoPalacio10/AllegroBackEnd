using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class ClaseDetalle
    {
        public ClaseDetalle()
        {
            ClasePracticaVideo = new HashSet<ClasePracticaVideo>();
            ClaseTeorica = new HashSet<ClaseTeorica>();
        }

        public int Id { get; set; }
        public int? ClaseCabeceraId { get; set; }
        public int? TipoClaseId { get; set; }
        public int? RecompensaId { get; set; }
        public bool? IsVideo { get; set; }

        public ClaseCabecera ClaseCabecera { get; set; }
        public ClaseDetalle IdNavigation { get; set; }
        public TipoClase TipoClase { get; set; }
        public ClaseDetalle InverseIdNavigation { get; set; }
        public ICollection<ClasePracticaVideo> ClasePracticaVideo { get; set; }
        public ICollection<ClaseTeorica> ClaseTeorica { get; set; }
    }
}
