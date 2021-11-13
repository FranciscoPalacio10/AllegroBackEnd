using System;
using System.Collections.Generic;

namespace AllegroBackEnd.ModelS
{
    public partial class ClaseTeorica
    {
        public int Id { get; set; }
        public int? ClaseDetalleId { get; set; }
        public int? PregunteroId { get; set; }
        public string Contendio { get; set; }

        public ClaseDetalle ClaseDetalle { get; set; }
    }
}
